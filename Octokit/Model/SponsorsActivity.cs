namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// An event related to sponsorship activity.
    /// </summary>
    public class SponsorsActivity : QueryableValue<SponsorsActivity>
    {
        internal SponsorsActivity(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// What action this activity indicates took place.
        /// </summary>
        public SponsorsActivityAction Action { get; }

        /// <summary>
        /// The sponsor's current privacy level.
        /// </summary>
        public SponsorshipPrivacy? CurrentPrivacyLevel { get; }

        /// <summary>
        /// The Node ID of the SponsorsActivity object
        /// </summary>
        public ID Id { get; }

        /// <summary>
        /// The platform that was used to pay for the sponsorship.
        /// </summary>
        public SponsorshipPaymentSource? PaymentSource { get; }

        /// <summary>
        /// The tier that the sponsorship used to use, for tier change events.
        /// </summary>
        public SponsorsTier PreviousSponsorsTier => this.CreateProperty(x => x.PreviousSponsorsTier, Octokit.Model.SponsorsTier.Create);

        /// <summary>
        /// The user or organization who triggered this activity and was/is sponsoring the sponsorable.
        /// </summary>
        public Sponsor Sponsor => this.CreateProperty(x => x.Sponsor, Octokit.Model.Sponsor.Create);

        /// <summary>
        /// The user or organization that is being sponsored, the maintainer.
        /// </summary>
        public ISponsorable Sponsorable => this.CreateProperty(x => x.Sponsorable, Octokit.Model.Internal.StubISponsorable.Create);

        /// <summary>
        /// The associated sponsorship tier.
        /// </summary>
        public SponsorsTier SponsorsTier => this.CreateProperty(x => x.SponsorsTier, Octokit.Model.SponsorsTier.Create);

        /// <summary>
        /// The timestamp of this event.
        /// </summary>
        public DateTimeOffset? Timestamp { get; }

        /// <summary>
        /// Was this sponsorship made alongside other sponsorships at the same time from the same sponsor?
        /// </summary>
        public bool ViaBulkSponsorship { get; }

        internal static SponsorsActivity Create(Expression expression)
        {
            return new SponsorsActivity(expression);
        }
    }
}