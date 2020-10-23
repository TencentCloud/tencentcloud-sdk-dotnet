/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubProjectResponse : AbstractModel
    {
        
        /// <summary>
        /// 作品信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductInfo")]
        public ProductInfo ProductInfo{ get; set; }

        /// <summary>
        /// 活动信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityInfo")]
        public ActivityInfo ActivityInfo{ get; set; }

        /// <summary>
        /// 分享标题
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareTitle")]
        public string ShareTitle{ get; set; }

        /// <summary>
        /// 分享描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareDesc")]
        public string ShareDesc{ get; set; }

        /// <summary>
        /// 分享图标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareImg")]
        public string ShareImg{ get; set; }

        /// <summary>
        /// 是否已创建策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasStrategy")]
        public ulong? HasStrategy{ get; set; }

        /// <summary>
        /// 子项目状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubProjectStatus")]
        public string SubProjectStatus{ get; set; }

        /// <summary>
        /// 分享公众号的appId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareAppId")]
        public string ShareAppId{ get; set; }

        /// <summary>
        /// 分享公众号的wsId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShareWsId")]
        public string ShareWsId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ProductInfo.", this.ProductInfo);
            this.SetParamObj(map, prefix + "ActivityInfo.", this.ActivityInfo);
            this.SetParamSimple(map, prefix + "ShareTitle", this.ShareTitle);
            this.SetParamSimple(map, prefix + "ShareDesc", this.ShareDesc);
            this.SetParamSimple(map, prefix + "ShareImg", this.ShareImg);
            this.SetParamSimple(map, prefix + "HasStrategy", this.HasStrategy);
            this.SetParamSimple(map, prefix + "SubProjectStatus", this.SubProjectStatus);
            this.SetParamSimple(map, prefix + "ShareAppId", this.ShareAppId);
            this.SetParamSimple(map, prefix + "ShareWsId", this.ShareWsId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

