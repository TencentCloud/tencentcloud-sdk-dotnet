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

    public class Scenario : AbstractModel
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 场景类型，如pts-http, pts-js, pts-trpc, pts-jmeter
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 场景状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 施压配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Load")]
        public Load Load{ get; set; }

        /// <summary>
        /// deprecated
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncodedScripts")]
        public string EncodedScripts{ get; set; }

        /// <summary>
        /// deprecated
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Configs")]
        public string[] Configs{ get; set; }

        /// <summary>
        /// deprecated
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extensions")]
        public string[] Extensions{ get; set; }

        /// <summary>
        /// 测试数据集
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Datasets")]
        public TestData[] Datasets{ get; set; }

        /// <summary>
        /// SLA规则的ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SLAId")]
        public string SLAId{ get; set; }

        /// <summary>
        /// Cron Job规则的ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CronId")]
        public string CronId{ get; set; }

        /// <summary>
        /// 场景创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 场景修改时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 项目ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// App ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 子用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 测试脚本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TestScripts")]
        public ScriptInfo[] TestScripts{ get; set; }

        /// <summary>
        /// 协议文件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocols")]
        public ProtocolInfo[] Protocols{ get; set; }

        /// <summary>
        /// 请求文件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestFiles")]
        public FileInfo[] RequestFiles{ get; set; }

        /// <summary>
        /// SLA 策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SLAPolicy")]
        public SLAPolicy SLAPolicy{ get; set; }

        /// <summary>
        /// 扩展包信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Plugins")]
        public FileInfo[] Plugins{ get; set; }

        /// <summary>
        /// 域名解析配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainNameConfig")]
        public DomainNameConfig DomainNameConfig{ get; set; }

        /// <summary>
        /// 通知事件回调
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotificationHooks")]
        public NotificationHook[] NotificationHooks{ get; set; }

        /// <summary>
        /// 创建人员
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 场景所在的项目的名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScenarioId", this.ScenarioId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Load.", this.Load);
            this.SetParamSimple(map, prefix + "EncodedScripts", this.EncodedScripts);
            this.SetParamArraySimple(map, prefix + "Configs.", this.Configs);
            this.SetParamArraySimple(map, prefix + "Extensions.", this.Extensions);
            this.SetParamArrayObj(map, prefix + "Datasets.", this.Datasets);
            this.SetParamSimple(map, prefix + "SLAId", this.SLAId);
            this.SetParamSimple(map, prefix + "CronId", this.CronId);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamArrayObj(map, prefix + "TestScripts.", this.TestScripts);
            this.SetParamArrayObj(map, prefix + "Protocols.", this.Protocols);
            this.SetParamArrayObj(map, prefix + "RequestFiles.", this.RequestFiles);
            this.SetParamObj(map, prefix + "SLAPolicy.", this.SLAPolicy);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamObj(map, prefix + "DomainNameConfig.", this.DomainNameConfig);
            this.SetParamArrayObj(map, prefix + "NotificationHooks.", this.NotificationHooks);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
        }
    }
}

