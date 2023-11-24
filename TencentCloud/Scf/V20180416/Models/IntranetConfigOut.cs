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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntranetConfigOut : AbstractModel
    {
        
        /// <summary>
        /// 是否启用固定内网IP
        /// ENABLE 为启用
        /// DISABLE 为不启用
        /// </summary>
        [JsonProperty("IpFixed")]
        public string IpFixed{ get; set; }

        /// <summary>
        /// 若已启用固定内网IP，则该字段返回使用的IP列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpAddress")]
        public string[] IpAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IpFixed", this.IpFixed);
            this.SetParamArraySimple(map, prefix + "IpAddress.", this.IpAddress);
        }
    }
}

