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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAigcQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><strong>点播应用 ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</strong></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>配额类型</p><p>枚举值：</p><ul><li>Image： AIGC 生图任务</li><li>Video： AIGC 生视频任务</li><li>Text： AIGC 生文任务</li></ul>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// <p>任务的配额数。</p><p>单位：张/秒/token数。</p><ul><li>当 QuotaType 为 Image 时，单位为张；</li><li>当 QuotaType 为 Video 时，单位为秒；</li><li>当 QuotaType 为 Text 时，单位为 token 数。</li></ul>
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public ulong? QuotaLimit{ get; set; }

        /// <summary>
        /// <p>仅当QuotaType=Text时有效，用于选择需要进行配额限制ApiToken</p>
        /// </summary>
        [JsonProperty("ApiToken")]
        public string ApiToken{ get; set; }

        /// <summary>
        /// <p>配额重置周期。</p><p>枚举值：</p><ul><li>Day： 每天重置。</li><li>Month： 每月指定日期重置。</li><li>Total： 永不重置，QuotaLimit参数即为总额度。</li></ul>
        /// </summary>
        [JsonProperty("QuotaPeriod")]
        public string QuotaPeriod{ get; set; }

        /// <summary>
        /// <p>每月配额的重置日期，仅QuotaPeriod=Month时有效。</p><p>如果当月无所选日期时，顺延至次月 1 日 00:00 重置。</p>
        /// </summary>
        [JsonProperty("ResetDay")]
        public ulong? ResetDay{ get; set; }

        /// <summary>
        /// <p>是否开启按单个模型设置配额</p><p>枚举值：</p><ul><li>ON： 打开</li><li>OFF： 关闭</li></ul>
        /// </summary>
        [JsonProperty("ModelQuotaSwitch")]
        public string ModelQuotaSwitch{ get; set; }

        /// <summary>
        /// <p>按单个模型设置的配额，仅ModelQuotaSwitch=ON时有效。</p>
        /// </summary>
        [JsonProperty("ModelQuotas")]
        public AigcModelQuota[] ModelQuotas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
            this.SetParamSimple(map, prefix + "ApiToken", this.ApiToken);
            this.SetParamSimple(map, prefix + "QuotaPeriod", this.QuotaPeriod);
            this.SetParamSimple(map, prefix + "ResetDay", this.ResetDay);
            this.SetParamSimple(map, prefix + "ModelQuotaSwitch", this.ModelQuotaSwitch);
            this.SetParamArrayObj(map, prefix + "ModelQuotas.", this.ModelQuotas);
        }
    }
}

