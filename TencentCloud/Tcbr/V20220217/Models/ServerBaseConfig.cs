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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerBaseConfig : AbstractModel
    {
        
        /// <summary>
        /// 环境 Id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// 是否开启公网访问
        /// </summary>
        [JsonProperty("OpenAccessTypes")]
        public string[] OpenAccessTypes{ get; set; }

        /// <summary>
        /// Cpu 规格
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// Mem 规格
        /// </summary>
        [JsonProperty("Mem")]
        public float? Mem{ get; set; }

        /// <summary>
        /// 最小副本数
        /// </summary>
        [JsonProperty("MinNum")]
        public ulong? MinNum{ get; set; }

        /// <summary>
        /// 最大副本数
        /// </summary>
        [JsonProperty("MaxNum")]
        public ulong? MaxNum{ get; set; }

        /// <summary>
        /// 扩缩容配置
        /// </summary>
        [JsonProperty("PolicyDetails")]
        public HpaPolicy[] PolicyDetails{ get; set; }

        /// <summary>
        /// 日志采集路径
        /// </summary>
        [JsonProperty("CustomLogs")]
        public string CustomLogs{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("EnvParams")]
        public string EnvParams{ get; set; }

        /// <summary>
        /// 延迟检测时间
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public ulong? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 服务端口
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 是否有Dockerfile
        /// </summary>
        [JsonProperty("HasDockerfile")]
        public bool? HasDockerfile{ get; set; }

        /// <summary>
        /// Dockerfile 文件名
        /// </summary>
        [JsonProperty("Dockerfile")]
        public string Dockerfile{ get; set; }

        /// <summary>
        /// 构建目录
        /// </summary>
        [JsonProperty("BuildDir")]
        public string BuildDir{ get; set; }

        /// <summary>
        /// 日志类型: none | default | custom
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// cls setId
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// cls 主题id
        /// </summary>
        [JsonProperty("LogTopicId")]
        public string LogTopicId{ get; set; }

        /// <summary>
        /// 解析类型：json ｜ line
        /// </summary>
        [JsonProperty("LogParseType")]
        public string LogParseType{ get; set; }

        /// <summary>
        /// 服务标签, function: 函数托管
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamArraySimple(map, prefix + "OpenAccessTypes.", this.OpenAccessTypes);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "MinNum", this.MinNum);
            this.SetParamSimple(map, prefix + "MaxNum", this.MaxNum);
            this.SetParamArrayObj(map, prefix + "PolicyDetails.", this.PolicyDetails);
            this.SetParamSimple(map, prefix + "CustomLogs", this.CustomLogs);
            this.SetParamSimple(map, prefix + "EnvParams", this.EnvParams);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "HasDockerfile", this.HasDockerfile);
            this.SetParamSimple(map, prefix + "Dockerfile", this.Dockerfile);
            this.SetParamSimple(map, prefix + "BuildDir", this.BuildDir);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "LogTopicId", this.LogTopicId);
            this.SetParamSimple(map, prefix + "LogParseType", this.LogParseType);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

