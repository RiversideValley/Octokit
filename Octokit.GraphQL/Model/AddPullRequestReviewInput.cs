namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of AddPullRequestReview
    /// </summary>
    public class AddPullRequestReviewInput
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The Node ID of the pull request to modify.
        /// </summary>
        public ID PullRequestId { get; set; }

        /// <summary>
        /// The commit OID the review pertains to.
        /// </summary>
        public string CommitOID { get; set; }

        /// <summary>
        /// The contents of the review body comment.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The event to perform on the pull request review.
        /// </summary>
        public PullRequestReviewEvent? Event { get; set; }

        /// <summary>
        /// The review line comments.
        /// **Upcoming Change on 2023-10-01 UTC**
        /// **Description:** `comments` will be removed. use the `threads` argument instead
        /// **Reason:** We are deprecating comment fields that use diff-relative positioning
        /// </summary>
        public IEnumerable<DraftPullRequestReviewComment> Comments { get; set; }

        /// <summary>
        /// The review line comment threads.
        /// </summary>
        public IEnumerable<DraftPullRequestReviewThread> Threads { get; set; }
    }
}