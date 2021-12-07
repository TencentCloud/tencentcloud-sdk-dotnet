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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterRiskItem : AbstractModel
    {
        
        /// <summary>
        /// 检测项相关信息
        /// </summary>
        [JsonProperty("CheckItem")]
        public ClusterCheckItem CheckItem{ get; set; }

        /// <summary>
        /// 验证信息
        /// </summary>
        [JsonProperty("VerifyInfo")]
        public string VerifyInfo{ get; set; }

        /// <summary>
        /// 事件描述,检查的错误信息
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 受影响的集群数量
        /// </summary>
        [JsonProperty("AffectedClusterCount")]
        public ulong? AffectedClusterCount{ get; set; }

        /// <summary>
        /// 受影响的节点数量
        /// </summary>
        [JsonProperty("AffectedNodeCount")]
        public ulong? AffectedNodeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CheckItem.", this.CheckItem);
            this.SetParamSimple(map, prefix + "VerifyInfo", this.VerifyInfo);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "AffectedClusterCount", this.AffectedClusterCount);
            this.SetParamSimple(map, prefix + "AffectedNodeCount", this.AffectedNodeCount);
        }
    }
}

