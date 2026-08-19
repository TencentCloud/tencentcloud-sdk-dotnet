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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMachinesLoginTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>登录方式：0-原始方式，1-扫码免密登录</p>
        /// </summary>
        [JsonProperty("LoginType")]
        public ulong? LoginType{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>instance_id列表(instance_ids和quuids至少要填一个)</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>主机quuid列表(instance_ids和quuids至少要填一个)</p>
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// <p>排除的quuid集合</p>
        /// </summary>
        [JsonProperty("ExcludeQuuid")]
        public string[] ExcludeQuuid{ get; set; }

        /// <summary>
        /// <p>开启范围 0 自选主机 1 全部主机</p>
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// <p>操作来源 :<br>0   主机页面<br>1   客户端设置页面<br>2   安全中心页面<br>3   LightHouse购买页<br>4   LightHouse控制台</p>
        /// </summary>
        [JsonProperty("From")]
        public ulong? From{ get; set; }

        /// <summary>
        /// <p>请求版本 0   原始版本 1   策略式请求</p>
        /// </summary>
        [JsonProperty("RequestVersion")]
        public long? RequestVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "ExcludeQuuid.", this.ExcludeQuuid);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "RequestVersion", this.RequestVersion);
        }
    }
}

