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

namespace TencentCloud.Btoe.V20210303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataDepositRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务数据明文(json格式字符串)，最大256kb
        /// </summary>
        [JsonProperty("EvidenceInfo")]
        public string EvidenceInfo{ get; set; }

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
        /// 业务ID 透传 长度最大不超过64
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 算法类型 0 SM3, 1 SHA256, 2 SHA384 默认0
        /// </summary>
        [JsonProperty("HashType")]
        public ulong? HashType{ get; set; }

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
            this.SetParamSimple(map, prefix + "EvidenceInfo", this.EvidenceInfo);
            this.SetParamSimple(map, prefix + "EvidenceName", this.EvidenceName);
            this.SetParamSimple(map, prefix + "EvidenceHash", this.EvidenceHash);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "HashType", this.HashType);
            this.SetParamSimple(map, prefix + "EvidenceDescription", this.EvidenceDescription);
        }
    }
}

