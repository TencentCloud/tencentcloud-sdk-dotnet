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

    public class DeactivateTDidRequest : AbstractModel
    {
        
        /// <summary>
        /// DID标识符
        /// </summary>
        [JsonProperty("Did")]
        public string Did{ get; set; }

        /// <summary>
        /// 设置DID禁用状态的临时凭证内容，通过创建凭证接口(CreateCredential)生成并签名，凭证类型为：OperateCredential, 为安全起见凭证过期时间不适合太长，建议设置为1分钟内
        /// </summary>
        [JsonProperty("OperateCredential")]
        public string OperateCredential{ get; set; }

        /// <summary>
        /// DID应用Id
        /// </summary>
        [JsonProperty("DAPId")]
        public ulong? DAPId{ get; set; }

        /// <summary>
        /// 是否禁用
        /// </summary>
        [JsonProperty("Deactivated")]
        public string Deactivated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Did", this.Did);
            this.SetParamSimple(map, prefix + "OperateCredential", this.OperateCredential);
            this.SetParamSimple(map, prefix + "DAPId", this.DAPId);
            this.SetParamSimple(map, prefix + "Deactivated", this.Deactivated);
        }
    }
}

