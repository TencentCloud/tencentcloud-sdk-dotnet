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

namespace TencentCloud.Ds.V20180523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateContractByUploadRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名ContractMng
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名CreateContractByUpload
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 签署人信息
        /// </summary>
        [JsonProperty("SignInfos")]
        public SignInfo[] SignInfos{ get; set; }

        /// <summary>
        /// 合同上传链接地址
        /// </summary>
        [JsonProperty("ContractFile")]
        public string ContractFile{ get; set; }

        /// <summary>
        /// 合同名称
        /// </summary>
        [JsonProperty("ContractName")]
        public string ContractName{ get; set; }

        /// <summary>
        /// 合同发起方帐号ID
        /// </summary>
        [JsonProperty("Initiator")]
        public string Initiator{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// 合同长时间未签署的过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamArrayObj(map, prefix + "SignInfos.", this.SignInfos);
            this.SetParamSimple(map, prefix + "ContractFile", this.ContractFile);
            this.SetParamSimple(map, prefix + "ContractName", this.ContractName);
            this.SetParamSimple(map, prefix + "Initiator", this.Initiator);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

