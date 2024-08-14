using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Trees;

public static class ValidateBinarySearchTree
{
    private static bool IsValidBST(TreeNode root)
    {
        return ValidateBST(root, null, null);
    }

    public static bool ValidateBST(TreeNode root, int? lowestValue, int? highestValue)
    {
        // If the tree is empty then it is valid
        if (root == null)
        {
            return true;
        }

        // Left side of the tree is valid if it's empty if it is valid by itself and none of the 
        // values is greater than or equal than root value and none of the values inside is less than 
        // or equal lowestValue
        bool isLeftValid = root.left == null ||
                            ((lowestValue is null || root.val > lowestValue) &&
                            ValidateBST(root.left, lowestValue, root.val));

        // Right side of the tree is valid if it is valid by itself and none of the values is less 
        // than or equal than root value
        bool isRightValid = root.right == null ||
                             ((lowestValue is null || root.val < highestValue) && 
                             ValidateBST(root.right, root.val, highestValue));

        return isLeftValid && isRightValid;
    }
}