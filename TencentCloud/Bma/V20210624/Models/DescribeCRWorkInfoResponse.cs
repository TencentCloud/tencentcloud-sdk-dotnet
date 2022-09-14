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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCRWorkInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("WorkName")]
        public string WorkName{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public long? MonitorStatus{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("AuthStatus")]
        public long? AuthStatus{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("CommStatus")]
        public long? CommStatus{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("IsProducer")]
        public long? IsProducer{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("EvidenceStatus")]
        public long? EvidenceStatus{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("WorkCategory")]
        public string WorkCategory{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("IsOriginal")]
        public string IsOriginal{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("IsRelease")]
        public string IsRelease{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProducerName")]
        public string ProducerName{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("WhiteLists")]
        public string[] WhiteLists{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("WorkDesc")]
        public string WorkDesc{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("Authorization")]
        public string Authorization{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("AuthorizationStartTime")]
        public string AuthorizationStartTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("AuthorizationEndTime")]
        public string AuthorizationEndTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("Commission")]
        public string Commission{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("CommissionStartTime")]
        public string CommissionStartTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("CommissionEndTime")]
        public string CommissionEndTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("EvidenceUrl")]
        public string EvidenceUrl{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("EvidenceStartTime")]
        public string EvidenceStartTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("EvidenceEndTime")]
        public string EvidenceEndTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "WorkName", this.WorkName);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
            this.SetParamSimple(map, prefix + "CommStatus", this.CommStatus);
            this.SetParamSimple(map, prefix + "IsProducer", this.IsProducer);
            this.SetParamSimple(map, prefix + "EvidenceStatus", this.EvidenceStatus);
            this.SetParamSimple(map, prefix + "WorkCategory", this.WorkCategory);
            this.SetParamSimple(map, prefix + "IsOriginal", this.IsOriginal);
            this.SetParamSimple(map, prefix + "IsRelease", this.IsRelease);
            this.SetParamSimple(map, prefix + "ProducerName", this.ProducerName);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamArraySimple(map, prefix + "WhiteLists.", this.WhiteLists);
            this.SetParamSimple(map, prefix + "WorkDesc", this.WorkDesc);
            this.SetParamSimple(map, prefix + "Authorization", this.Authorization);
            this.SetParamSimple(map, prefix + "AuthorizationStartTime", this.AuthorizationStartTime);
            this.SetParamSimple(map, prefix + "AuthorizationEndTime", this.AuthorizationEndTime);
            this.SetParamSimple(map, prefix + "Commission", this.Commission);
            this.SetParamSimple(map, prefix + "CommissionStartTime", this.CommissionStartTime);
            this.SetParamSimple(map, prefix + "CommissionEndTime", this.CommissionEndTime);
            this.SetParamSimple(map, prefix + "EvidenceUrl", this.EvidenceUrl);
            this.SetParamSimple(map, prefix + "EvidenceStartTime", this.EvidenceStartTime);
            this.SetParamSimple(map, prefix + "EvidenceEndTime", this.EvidenceEndTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

