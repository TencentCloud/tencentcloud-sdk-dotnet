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

namespace TencentCloud.Sts.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFederationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 联合身份用户昵称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 策略描述
        /// 注意：
        /// 1、policy 需要做 urlencode（如果通过 GET 方法请求云 API，发送请求前，所有参数都需要按照云 API 规范再 urlencode 一次）。
        /// 2、策略语法参照 CAM 策略语法。
        /// 3、策略中不能包含 principal 元素。
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// 指定临时证书的有效期，单位：秒，默认1800秒，最长可设定有效期为7200秒
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public ulong? DurationSeconds{ get; set; }

        /// <summary>
        /// 兼容uin名单
        /// </summary>
        [JsonProperty("OpenUin")]
        public ulong? OpenUin{ get; set; }

        /// <summary>
        /// 兼容OwnerUin名单
        /// </summary>
        [JsonProperty("OpenOwnerUin")]
        public ulong? OpenOwnerUin{ get; set; }

        /// <summary>
        /// ua
        /// </summary>
        [JsonProperty("Ua")]
        public string Ua{ get; set; }

        /// <summary>
        /// mfa
        /// </summary>
        [JsonProperty("Mfa")]
        public ulong? Mfa{ get; set; }

        /// <summary>
        /// interfaceName
        /// </summary>
        [JsonProperty("InterfaceName")]
        public string InterfaceName{ get; set; }

        /// <summary>
        /// extraInfo
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// thUin
        /// </summary>
        [JsonProperty("ThUin")]
        public ulong? ThUin{ get; set; }

        /// <summary>
        /// thOwnerUin
        /// </summary>
        [JsonProperty("ThOwnerUin")]
        public ulong? ThOwnerUin{ get; set; }

        /// <summary>
        /// codeMode
        /// </summary>
        [JsonProperty("CodeMode")]
        public string CodeMode{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
            this.SetParamSimple(map, prefix + "OpenUin", this.OpenUin);
            this.SetParamSimple(map, prefix + "OpenOwnerUin", this.OpenOwnerUin);
            this.SetParamSimple(map, prefix + "Ua", this.Ua);
            this.SetParamSimple(map, prefix + "Mfa", this.Mfa);
            this.SetParamSimple(map, prefix + "InterfaceName", this.InterfaceName);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "ThUin", this.ThUin);
            this.SetParamSimple(map, prefix + "ThOwnerUin", this.ThOwnerUin);
            this.SetParamSimple(map, prefix + "CodeMode", this.CodeMode);
        }
    }
}

