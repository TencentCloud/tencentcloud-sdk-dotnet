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

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendTransactionHandlerRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，固定字段：transaction
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名，固定字段：send_transaction
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 群组编号
        /// </summary>
        [JsonProperty("GroupPk")]
        public string GroupPk{ get; set; }

        /// <summary>
        /// 私钥用户编号
        /// </summary>
        [JsonProperty("KeyUser")]
        public string KeyUser{ get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonProperty("ContractId")]
        public long? ContractId{ get; set; }

        /// <summary>
        /// 合约方法名
        /// </summary>
        [JsonProperty("FuncName")]
        public string FuncName{ get; set; }

        /// <summary>
        /// 合约方法入参
        /// </summary>
        [JsonProperty("FuncParam")]
        public string[] FuncParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "GroupPk", this.GroupPk);
            this.SetParamSimple(map, prefix + "KeyUser", this.KeyUser);
            this.SetParamSimple(map, prefix + "ContractId", this.ContractId);
            this.SetParamSimple(map, prefix + "FuncName", this.FuncName);
            this.SetParamArraySimple(map, prefix + "FuncParam.", this.FuncParam);
        }
    }
}

