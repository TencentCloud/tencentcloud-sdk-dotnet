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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosAuthMode : AbstractModel
    {
        
        /// <summary>
        /// 授权类型，可选值： 
        /// 0：bucket授权，需要将对应bucket授权给本服务帐号（3020447271和100012301793），否则会读写cos失败； 
        /// 1：key托管，把cos的账号id和key托管于本服务，本服务会提供一个托管id； 
        /// 3：临时key授权。
        /// 注意：目前智能编辑还不支持临时key授权；画质重生目前只支持bucket授权
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// cos账号托管id，Type等于1时必选。
        /// </summary>
        [JsonProperty("HostedId")]
        public string HostedId{ get; set; }

        /// <summary>
        /// cos身份识别id，Type等于3时必选。
        /// </summary>
        [JsonProperty("SecretId")]
        public string SecretId{ get; set; }

        /// <summary>
        /// cos身份秘钥，Type等于3时必选。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 临时授权 token，Type等于3时必选。
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "HostedId", this.HostedId);
            this.SetParamSimple(map, prefix + "SecretId", this.SecretId);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Token", this.Token);
        }
    }
}

