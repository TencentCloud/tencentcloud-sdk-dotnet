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

    public class ServerBaseConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>环境 Id</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>服务名</p>
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// <p>是否开启公网访问</p>
        /// </summary>
        [JsonProperty("OpenAccessTypes")]
        public string[] OpenAccessTypes{ get; set; }

        /// <summary>
        /// <p>Cpu 规格</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// <p>Mem 规格</p>
        /// </summary>
        [JsonProperty("Mem")]
        public float? Mem{ get; set; }

        /// <summary>
        /// <p>最小副本数</p>
        /// </summary>
        [JsonProperty("MinNum")]
        public ulong? MinNum{ get; set; }

        /// <summary>
        /// <p>最大副本数</p>
        /// </summary>
        [JsonProperty("MaxNum")]
        public ulong? MaxNum{ get; set; }

        /// <summary>
        /// <p>扩缩容配置</p>
        /// </summary>
        [JsonProperty("PolicyDetails")]
        public HpaPolicy[] PolicyDetails{ get; set; }

        /// <summary>
        /// <p>日志采集路径</p>
        /// </summary>
        [JsonProperty("CustomLogs")]
        public string CustomLogs{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// </summary>
        [JsonProperty("EnvParams")]
        public string EnvParams{ get; set; }

        /// <summary>
        /// <p>延迟检测时间</p>
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public ulong? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>服务端口</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>是否有Dockerfile</p>
        /// </summary>
        [JsonProperty("HasDockerfile")]
        public bool? HasDockerfile{ get; set; }

        /// <summary>
        /// <p>Dockerfile 文件名</p>
        /// </summary>
        [JsonProperty("Dockerfile")]
        public string Dockerfile{ get; set; }

        /// <summary>
        /// <p>构建目录</p>
        /// </summary>
        [JsonProperty("BuildDir")]
        public string BuildDir{ get; set; }

        /// <summary>
        /// <p>日志类型: none | default | custom</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p>cls setId</p>
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// <p>cls 主题id</p>
        /// </summary>
        [JsonProperty("LogTopicId")]
        public string LogTopicId{ get; set; }

        /// <summary>
        /// <p>解析类型：json ｜ line</p>
        /// </summary>
        [JsonProperty("LogParseType")]
        public string LogParseType{ get; set; }

        /// <summary>
        /// <p>服务标签, function: 函数托管</p>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>内网访问开关 close | open</p>
        /// </summary>
        [JsonProperty("InternalAccess")]
        public string InternalAccess{ get; set; }

        /// <summary>
        /// <p>内网域名</p>
        /// </summary>
        [JsonProperty("InternalDomain")]
        public string InternalDomain{ get; set; }

        /// <summary>
        /// <p>运行模式</p>
        /// </summary>
        [JsonProperty("OperationMode")]
        public string OperationMode{ get; set; }

        /// <summary>
        /// <p>定时扩缩容配置</p>
        /// </summary>
        [JsonProperty("TimerScale")]
        public TimerScale[] TimerScale{ get; set; }

        /// <summary>
        /// <p>Dockerfile EntryPoint 参数</p>
        /// </summary>
        [JsonProperty("EntryPoint")]
        public string[] EntryPoint{ get; set; }

        /// <summary>
        /// <p>Dockerfile Cmd 参数</p>
        /// </summary>
        [JsonProperty("Cmd")]
        public string[] Cmd{ get; set; }

        /// <summary>
        /// <p>会话亲和性开关</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionAffinity")]
        public string SessionAffinity{ get; set; }

        /// <summary>
        /// <p>Vpc 配置参数</p>
        /// </summary>
        [JsonProperty("VpcConf")]
        public VpcConf VpcConf{ get; set; }

        /// <summary>
        /// <p>存储配置信息</p>
        /// </summary>
        [JsonProperty("VolumesConf")]
        public VolumeConf[] VolumesConf{ get; set; }

        /// <summary>
        /// <p>关联镜像密钥</p>
        /// </summary>
        [JsonProperty("LinkImageRegistry")]
        public string LinkImageRegistry{ get; set; }

        /// <summary>
        /// <p>公网访问配置</p>
        /// </summary>
        [JsonProperty("PublicNetConf")]
        public PublicNetConf PublicNetConf{ get; set; }


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
            this.SetParamSimple(map, prefix + "InternalAccess", this.InternalAccess);
            this.SetParamSimple(map, prefix + "InternalDomain", this.InternalDomain);
            this.SetParamSimple(map, prefix + "OperationMode", this.OperationMode);
            this.SetParamArrayObj(map, prefix + "TimerScale.", this.TimerScale);
            this.SetParamArraySimple(map, prefix + "EntryPoint.", this.EntryPoint);
            this.SetParamArraySimple(map, prefix + "Cmd.", this.Cmd);
            this.SetParamSimple(map, prefix + "SessionAffinity", this.SessionAffinity);
            this.SetParamObj(map, prefix + "VpcConf.", this.VpcConf);
            this.SetParamArrayObj(map, prefix + "VolumesConf.", this.VolumesConf);
            this.SetParamSimple(map, prefix + "LinkImageRegistry", this.LinkImageRegistry);
            this.SetParamObj(map, prefix + "PublicNetConf.", this.PublicNetConf);
        }
    }
}

