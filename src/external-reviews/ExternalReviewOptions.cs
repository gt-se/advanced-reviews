﻿using System;
using AdvancedExternalReviews.Properties;
using EPiServer.ServiceLocation;

namespace AdvancedExternalReviews
{
    [Options]
    public class ExternalReviewOptions
    {
        public string ReviewsUrl { get; set; } = "externalContentReviews";

        /// <summary>
        /// URL used for displaying readonly version of page
        /// </summary>
        public string ContentPreviewUrl { get; set; } = "externalContentView";

        /// <summary>
        /// URL to editable content iframe
        /// </summary>
        public string ContentIframeEditUrlSegment { get; set; } = "externalPageReview";

        /// <summary>
        /// email subject template
        /// </summary>
        public string EmailSubject { get; set; } = Resources.EmailSubject;

        /// <summary>
        /// email template used for editable links
        /// </summary>
        public string EmailEdit { get; set; } = Resources.mail_edit;

        /// <summary>
        /// email template used for readonly content links
        /// </summary>
        public string EmailView { get; set; } = Resources.mail_preview;

        /// <summary>
        /// When true then Editor can create editable links
        /// </summary>
        public bool EditableLinksEnabled { get; set; } = false;

        /// <summary>
        /// For how long view link is valid
        /// </summary>
        public TimeSpan ViewLinkValidTo { get; set; } = TimeSpan.FromDays(5);

        /// <summary>
        /// For how long editable link is valid
        /// </summary>
        public TimeSpan EditLinkValidTo { get; set; } = TimeSpan.FromDays(5);

        /// <summary>
        /// Restriction options
        /// </summary>
        public ExternalReviewRestrictionOptions Restrictions { get; } = new ExternalReviewRestrictionOptions();
    }

    public class ExternalReviewRestrictionOptions
    {
        /// <summary>
        /// Maximum number of review locations that can be added to the page
        /// </summary>
        public int MaxReviewLocationsForContent { get; set; } = int.MaxValue;

        /// <summary>
        /// Maximum number of comments that can be added to one review location
        /// </summary>
        public int MaxCommentsForReviewLocation { get; set; } = int.MaxValue;

        /// <summary>
        /// maximum length of comment
        /// </summary>
        public int MaxCommentLength { get; set; } = int.MaxValue;
    }
}
