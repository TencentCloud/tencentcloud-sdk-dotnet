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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateScenarioRequest : AbstractModel
    {
        
        /// <summary>
        /// 场景ID
        /// </summary>
        [JsonProperty("ScenarioId")]
        public string ScenarioId{ get; set; }

        /// <summary>
        /// 场景名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 场景描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 压测引擎类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 施压配置
        /// </summary>
        [JsonProperty("Load")]
        public Load Load{ get; set; }

        /// <summary>
        /// deprecated
        /// </summary>
        [JsonProperty("EncodedScripts")]
        public string EncodedScripts{ get; set; }

        /// <summary>
        /// deprecated
        /// </summary>
        [JsonProperty("Configs")]
        public string[] Configs{ get; set; }

        /// <summary>
        /// 测试数据集
        /// </summary>
        [JsonProperty("Datasets")]
        public TestData[] Datasets{ get; set; }

        /// <summary>
        /// deprecated
        /// </summary>
        [JsonProperty("Extensions")]
        public string[] Extensions{ get; set; }

        /// <summary>
        /// SLA规则ID
        /// </summary>
        [JsonProperty("SLAId")]
        public string SLAId{ get; set; }

        /// <summary>
        /// cron job ID
        /// </summary>
        [JsonProperty("CronId")]
        public string CronId{ get; set; }

        /// <summary>
        /// 场景状态（注：现已无需传递该参数）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 测试脚本路径
        /// </summary>
        [JsonProperty("TestScripts")]
        public ScriptInfo[] TestScripts{ get; set; }

        /// <summary>
        /// 协议文件路径
        /// </summary>
        [JsonProperty("Protocols")]
        public ProtocolInfo[] Protocols{ get; set; }

        /// <summary>
        /// 请求文件路径
        /// </summary>
        [JsonProperty("RequestFiles")]
        public FileInfo[] RequestFiles{ get; set; }

        /// <summary>
        /// SLA 策略
        /// </summary>
        [JsonProperty("SLAPolicy")]
        public SLAPolicy SLAPolicy{ get; set; }

        /// <summary>
        /// 拓展包文件路径
        /// </summary>
        [JsonProperty("Plugins")]
        public FileInfo[] Plugins{ get; set; }

        /// <summary>
        /// 域名解析配置
        /// </summary>
        [JsonProperty("DomainNameConfig")]
        public DomainNameConfig DomainNameConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScenarioId", this.ScenarioId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Load.", this.Load);
            this.SetParamSimple(map, prefix + "EncodedScripts", this.EncodedScripts);
            this.SetParamArraySimple(map, prefix + "Configs.", this.Configs);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamArraySimple(map, prefix + "Extensions.", this.Extensions);
            this.SetParamSimple(map, prefix + "SLAId", this.SLAId);
            this.SetParamSimple(map, prefix + "CronId", this.CronId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "TestScripts.", this.TestScripts);
            this.SetParamArrayObj(map, prefix + "Protocols.", this.Protocols);
            this.SetParamArrayObj(map, prefix + "RequestFiles.", this.RequestFiles);
            this.SetParamObj(map, prefix + "SLAPolicy.", this.SLAPolicy);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamObj(map, prefix + "DomainNameConfig.", this.DomainNameConfig);
        }
    }
}

