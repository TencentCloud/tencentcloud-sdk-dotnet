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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountVpcInfo : AbstractModel
    {
        
        /// <summary>
        /// VpcId： vpc-xadsafsdasd
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Vpc所属地区: ap-guangzhou, ap-shanghai
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Vpc所属账号: 123456789
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// vpc资源名称：testname
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
        }
    }
}

