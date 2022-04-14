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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudAttachmentInfo : AbstractModel
    {
        
        /// <summary>
        /// 附加项金额。
        /// 附加项的金额（必须是正数，单位：分），代表积分的数量、抵扣的金额、溢价的金额、补贴的金额
        /// </summary>
        [JsonProperty("AttachmentAmount")]
        public long? AttachmentAmount{ get; set; }

        /// <summary>
        /// 附加项类型。
        /// Add：加项；
        /// Sub：减项；
        /// Point：积分项；
        /// Subsidy：补贴项。
        /// </summary>
        [JsonProperty("AttachmentType")]
        public string AttachmentType{ get; set; }

        /// <summary>
        /// 附加项名称。
        /// 当银行作为收单机构可能会对该字段有要求，请向米大师确认。
        /// </summary>
        [JsonProperty("AttachmentName")]
        public string AttachmentName{ get; set; }

        /// <summary>
        /// 附加项编号。
        /// 当银行作为收单机构可能会对该字段有要求，请向米大师确认。
        /// </summary>
        [JsonProperty("AttachmentCode")]
        public string AttachmentCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttachmentAmount", this.AttachmentAmount);
            this.SetParamSimple(map, prefix + "AttachmentType", this.AttachmentType);
            this.SetParamSimple(map, prefix + "AttachmentName", this.AttachmentName);
            this.SetParamSimple(map, prefix + "AttachmentCode", this.AttachmentCode);
        }
    }
}

