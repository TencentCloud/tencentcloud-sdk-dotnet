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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Evaluation : AbstractModel
    {
        
        /// <summary>
        /// 已评估资源ID。长度为0~256个字符
        /// </summary>
        [JsonProperty("ComplianceResourceId")]
        public string ComplianceResourceId{ get; set; }

        /// <summary>
        /// 已评估资源类型。
        /// 支持:
        /// QCS::CVM::Instance、 QCS::CBS::Disk、QCS::VPC::Vpc、QCS::VPC::Subnet、QCS::VPC::SecurityGroup、 QCS::CAM::User、QCS::CAM::Group、QCS::CAM::Policy、QCS::CAM::Role、QCS::COS::Bucket
        /// </summary>
        [JsonProperty("ComplianceResourceType")]
        public string ComplianceResourceType{ get; set; }

        /// <summary>
        /// 已评估资源地域。
        /// 长度为0~32个字符
        /// </summary>
        [JsonProperty("ComplianceRegion")]
        public string ComplianceRegion{ get; set; }

        /// <summary>
        /// 合规类型。取值：
        /// COMPLIANT：合规、
        /// NON_COMPLIANT：不合规
        /// </summary>
        [JsonProperty("ComplianceType")]
        public string ComplianceType{ get; set; }

        /// <summary>
        /// 不合规资源的补充信息。
        /// </summary>
        [JsonProperty("Annotation")]
        public Annotation Annotation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComplianceResourceId", this.ComplianceResourceId);
            this.SetParamSimple(map, prefix + "ComplianceResourceType", this.ComplianceResourceType);
            this.SetParamSimple(map, prefix + "ComplianceRegion", this.ComplianceRegion);
            this.SetParamSimple(map, prefix + "ComplianceType", this.ComplianceType);
            this.SetParamObj(map, prefix + "Annotation.", this.Annotation);
        }
    }
}

