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

namespace TencentCloud.Btoe.V20210514.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateHashDepositRequest : AbstractModel
    {
        
        /// <summary>
        /// 存证名称(长度最大30)
        /// </summary>
        [JsonProperty("EvidenceName")]
        public string EvidenceName{ get; set; }

        /// <summary>
        /// 数据hash
        /// </summary>
        [JsonProperty("EvidenceHash")]
        public string EvidenceHash{ get; set; }

        /// <summary>
        /// 该字段为透传字段，方便调用方做业务处理， 长度最大不超过64
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 存证描述
        /// </summary>
        [JsonProperty("EvidenceDescription")]
        public string EvidenceDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvidenceName", this.EvidenceName);
            this.SetParamSimple(map, prefix + "EvidenceHash", this.EvidenceHash);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "EvidenceDescription", this.EvidenceDescription);
        }
    }
}

