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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerModel : AbstractModel
    {
        
        /// <summary>
        /// 型号名称
        /// </summary>
        [JsonProperty("DevModel")]
        public string DevModel{ get; set; }

        /// <summary>
        /// 节点数
        /// </summary>
        [JsonProperty("DevNode")]
        public string DevNode{ get; set; }

        /// <summary>
        /// 设备高度
        /// </summary>
        [JsonProperty("DevHeight")]
        public string DevHeight{ get; set; }

        /// <summary>
        /// 功耗
        /// </summary>
        [JsonProperty("PowerEnergy")]
        public string PowerEnergy{ get; set; }

        /// <summary>
        /// 电源接口型号
        /// </summary>
        [JsonProperty("PowerportType")]
        public string PowerportType{ get; set; }

        /// <summary>
        /// 电源模块数量
        /// </summary>
        [JsonProperty("PowermoduleNum")]
        public string PowermoduleNum{ get; set; }

        /// <summary>
        /// 进风口位置
        /// </summary>
        [JsonProperty("InwindPosition")]
        public string InwindPosition{ get; set; }

        /// <summary>
        /// 出风口位置
        /// </summary>
        [JsonProperty("OutwindPosition")]
        public string OutwindPosition{ get; set; }

        /// <summary>
        /// 网卡接口位置
        /// </summary>
        [JsonProperty("NetportPosition")]
        public string NetportPosition{ get; set; }

        /// <summary>
        /// 宽度
        /// </summary>
        [JsonProperty("DevWidth")]
        public string DevWidth{ get; set; }

        /// <summary>
        /// 深度
        /// </summary>
        [JsonProperty("DevDepth")]
        public string DevDepth{ get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [JsonProperty("DevWeight")]
        public string DevWeight{ get; set; }

        /// <summary>
        /// 电源模块
        /// </summary>
        [JsonProperty("PowerModule")]
        public string PowerModule{ get; set; }

        /// <summary>
        /// 电源模块位置
        /// </summary>
        [JsonProperty("PowermodulePosition")]
        public string PowermodulePosition{ get; set; }

        /// <summary>
        /// 网络接口类型
        /// </summary>
        [JsonProperty("NetportType")]
        public string NetportType{ get; set; }

        /// <summary>
        /// 网卡速率
        /// </summary>
        [JsonProperty("NetSpeed")]
        public string NetSpeed{ get; set; }

        /// <summary>
        /// 0 代表在当前园区没评估过，1 代表完全满足IDC准入标准 2 代表存在托管风险 3 代表不满足IDC准入标准
        /// </summary>
        [JsonProperty("CheckResult")]
        public ulong? CheckResult{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 型号和版本的组合名称
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DevModel", this.DevModel);
            this.SetParamSimple(map, prefix + "DevNode", this.DevNode);
            this.SetParamSimple(map, prefix + "DevHeight", this.DevHeight);
            this.SetParamSimple(map, prefix + "PowerEnergy", this.PowerEnergy);
            this.SetParamSimple(map, prefix + "PowerportType", this.PowerportType);
            this.SetParamSimple(map, prefix + "PowermoduleNum", this.PowermoduleNum);
            this.SetParamSimple(map, prefix + "InwindPosition", this.InwindPosition);
            this.SetParamSimple(map, prefix + "OutwindPosition", this.OutwindPosition);
            this.SetParamSimple(map, prefix + "NetportPosition", this.NetportPosition);
            this.SetParamSimple(map, prefix + "DevWidth", this.DevWidth);
            this.SetParamSimple(map, prefix + "DevDepth", this.DevDepth);
            this.SetParamSimple(map, prefix + "DevWeight", this.DevWeight);
            this.SetParamSimple(map, prefix + "PowerModule", this.PowerModule);
            this.SetParamSimple(map, prefix + "PowermodulePosition", this.PowermodulePosition);
            this.SetParamSimple(map, prefix + "NetportType", this.NetportType);
            this.SetParamSimple(map, prefix + "NetSpeed", this.NetSpeed);
            this.SetParamSimple(map, prefix + "CheckResult", this.CheckResult);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
        }
    }
}

