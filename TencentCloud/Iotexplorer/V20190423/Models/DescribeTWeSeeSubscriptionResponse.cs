/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTWeSeeSubscriptionResponse : AbstractModel
    {
        
        /// <summary>
        /// 资源 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 套餐规格。可能取值：
        /// 
        /// - `BASIC`：包年包月基础版（适用于视频理解）
        /// </summary>
        [JsonProperty("ServiceTier")]
        public string ServiceTier{ get; set; }

        /// <summary>
        /// 到期时间，秒级时间戳
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 启用状态，`true` 为开启，`false` 为关闭
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 订阅状态。可能取值：
        /// 
        /// - `NORMAL`：正常
        /// - `ISOLATED`：隔离
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 视觉理解配置（适用于视频理解、图片理解）
        /// </summary>
        [JsonProperty("ComprehensionConfig")]
        public SeeComprehensionConfig ComprehensionConfig{ get; set; }

        /// <summary>
        /// 视频语义浓缩配置（适用于视频语义浓缩）
        /// </summary>
        [JsonProperty("CompHighlightConfig")]
        public SeeCompHighlightConfig CompHighlightConfig{ get; set; }

        /// <summary>
        /// 云存事件 ID 过滤规则配置项
        /// </summary>
        [JsonProperty("EventIdFilterConfig")]
        public SeeEventIdFilterConfig EventIdFilterConfig{ get; set; }

        /// <summary>
        /// 当前周期基础能力总额度
        /// </summary>
        [JsonProperty("QuotaBasic")]
        public long? QuotaBasic{ get; set; }

        /// <summary>
        /// 当前周期基础能力已用额度
        /// </summary>
        [JsonProperty("QuotaUsedBasic")]
        public long? QuotaUsedBasic{ get; set; }

        /// <summary>
        /// 当前周期高级能力总额度
        /// </summary>
        [JsonProperty("QuotaAdvanced")]
        public long? QuotaAdvanced{ get; set; }

        /// <summary>
        /// 当前周期高级能力已用额度
        /// </summary>
        [JsonProperty("QuotaUsedAdvanced")]
        public long? QuotaUsedAdvanced{ get; set; }

        /// <summary>
        /// 额度刷新时间
        /// </summary>
        [JsonProperty("QuotaRefreshTime")]
        public long? QuotaRefreshTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ServiceTier", this.ServiceTier);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "ComprehensionConfig.", this.ComprehensionConfig);
            this.SetParamObj(map, prefix + "CompHighlightConfig.", this.CompHighlightConfig);
            this.SetParamObj(map, prefix + "EventIdFilterConfig.", this.EventIdFilterConfig);
            this.SetParamSimple(map, prefix + "QuotaBasic", this.QuotaBasic);
            this.SetParamSimple(map, prefix + "QuotaUsedBasic", this.QuotaUsedBasic);
            this.SetParamSimple(map, prefix + "QuotaAdvanced", this.QuotaAdvanced);
            this.SetParamSimple(map, prefix + "QuotaUsedAdvanced", this.QuotaUsedAdvanced);
            this.SetParamSimple(map, prefix + "QuotaRefreshTime", this.QuotaRefreshTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

