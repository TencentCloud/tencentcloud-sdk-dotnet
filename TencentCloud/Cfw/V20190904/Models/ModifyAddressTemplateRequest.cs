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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAddressTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 地址模板唯一Id
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// Type为1，ip模板eg：1.1.1.1,2.2.2.2；
        /// Type为5，域名模板eg：www.qq.com,www.tencent.com
        /// </summary>
        [JsonProperty("IpString")]
        public string IpString{ get; set; }

        /// <summary>
        /// 1 ip模板  5 域名模板
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 协议端口模板，协议类型，4:4层协议，7:7层协议。Type=6时必填。
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "IpString", this.IpString);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
        }
    }
}

