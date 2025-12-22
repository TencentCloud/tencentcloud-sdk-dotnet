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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVersionDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 版本名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// cpu 规格
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// mem 规格
        /// </summary>
        [JsonProperty("Mem")]
        public float? Mem{ get; set; }

        /// <summary>
        /// 最小副本数
        /// </summary>
        [JsonProperty("MinNum")]
        public long? MinNum{ get; set; }

        /// <summary>
        /// 最大副本数
        /// </summary>
        [JsonProperty("MaxNum")]
        public long? MaxNum{ get; set; }

        /// <summary>
        /// 扩缩容策略
        /// </summary>
        [JsonProperty("PolicyDetails")]
        public HpaPolicy[] PolicyDetails{ get; set; }

        /// <summary>
        /// Dockerfile path
        /// </summary>
        [JsonProperty("Dockerfile")]
        public string Dockerfile{ get; set; }

        /// <summary>
        /// 目标目录
        /// </summary>
        [JsonProperty("BuildDir")]
        public string BuildDir{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("EnvParams")]
        public string EnvParams{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 日志采集路径
        /// </summary>
        [JsonProperty("LogPath")]
        public string LogPath{ get; set; }

        /// <summary>
        /// entryPoint
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EntryPoint")]
        public string EntryPoint{ get; set; }

        /// <summary>
        /// Cmd
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }

        /// <summary>
        /// vpc conf
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcConf")]
        public VpcConf VpcConf{ get; set; }

        /// <summary>
        /// volume conf
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumesConf")]
        public VolumeConf[] VolumesConf{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "MinNum", this.MinNum);
            this.SetParamSimple(map, prefix + "MaxNum", this.MaxNum);
            this.SetParamArrayObj(map, prefix + "PolicyDetails.", this.PolicyDetails);
            this.SetParamSimple(map, prefix + "Dockerfile", this.Dockerfile);
            this.SetParamSimple(map, prefix + "BuildDir", this.BuildDir);
            this.SetParamSimple(map, prefix + "EnvParams", this.EnvParams);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "LogPath", this.LogPath);
            this.SetParamSimple(map, prefix + "EntryPoint", this.EntryPoint);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamObj(map, prefix + "VpcConf.", this.VpcConf);
            this.SetParamArrayObj(map, prefix + "VolumesConf.", this.VolumesConf);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

