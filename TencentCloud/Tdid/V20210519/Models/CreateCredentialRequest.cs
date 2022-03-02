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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCredentialRequest : AbstractModel
    {
        
        /// <summary>
        /// 参数集合，详见示例
        /// </summary>
        [JsonProperty("FunctionArg")]
        public FunctionArg FunctionArg{ get; set; }

        /// <summary>
        /// 参数集合，详见示例
        /// </summary>
        [JsonProperty("TransactionArg")]
        public TransactionArg TransactionArg{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("VersionCredential")]
        public string VersionCredential{ get; set; }

        /// <summary>
        /// 是否未签名
        /// </summary>
        [JsonProperty("UnSigned")]
        public bool? UnSigned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FunctionArg.", this.FunctionArg);
            this.SetParamObj(map, prefix + "TransactionArg.", this.TransactionArg);
            this.SetParamSimple(map, prefix + "VersionCredential", this.VersionCredential);
            this.SetParamSimple(map, prefix + "UnSigned", this.UnSigned);
        }
    }
}

