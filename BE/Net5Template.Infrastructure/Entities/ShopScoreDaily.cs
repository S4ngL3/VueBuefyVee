using System;
using System.Collections.Generic;

namespace Net5Template.Data.Entities
{
    /// <summary>
    /// Entity class representing data for table 'SHOP_SCORE_DAILY'.
    /// </summary>
    public partial class ShopScoreDaily
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopScoreDaily"/> class.
        /// </summary>
        public ShopScoreDaily()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        /// <summary>
        /// Gets or sets the property value representing column 'date'.
        /// </summary>
        /// <value>
        /// The property value representing column 'date'.
        /// </value>
        public long? Date { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'int_shop_id'.
        /// </summary>
        /// <value>
        /// The property value representing column 'int_shop_id'.
        /// </value>
        public int? IntShopId { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCORE_LAST_DATE_NUM'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCORE_LAST_DATE_NUM'.
        /// </value>
        public int? ScoreLastDateNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCORE_ORI_CHANGE_NUM'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCORE_ORI_CHANGE_NUM'.
        /// </value>
        public int? ScoreOriChangeNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SORE_NUM'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SORE_NUM'.
        /// </value>
        public int? SoreNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'SCORE_CHANGE_NUM'.
        /// </summary>
        /// <value>
        /// The property value representing column 'SCORE_CHANGE_NUM'.
        /// </value>
        public int ScoreChangeNum { get; set; }

        /// <summary>
        /// Gets or sets the property value representing column 'FGift_content'.
        /// </summary>
        /// <value>
        /// The property value representing column 'FGift_content'.
        /// </value>
        public string FGiftContent { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
