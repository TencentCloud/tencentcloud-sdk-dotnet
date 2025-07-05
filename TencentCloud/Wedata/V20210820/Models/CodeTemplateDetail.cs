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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CodeTemplateDetail : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 模版名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeTemplateName")]
        public string CodeTemplateName{ get; set; }

        /// <summary>
        /// 任务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 代码模版描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeTemplateDesc")]
        public string CodeTemplateDesc{ get; set; }

        /// <summary>
        /// 文件夹id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 文件夹名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// 责任人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// 责任人id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InChargeId")]
        public string InChargeId{ get; set; }

        /// <summary>
        /// 扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ext")]
        public TaskExtDsVO Ext{ get; set; }

        /// <summary>
        /// 模版id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeTemplateId")]
        public string CodeTemplateId{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// 更新人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUser")]
        public string UpdateUser{ get; set; }

        /// <summary>
        /// 更新人id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUserId")]
        public string UpdateUserId{ get; set; }

        /// <summary>
        /// 执行ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// 资源组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// 是否提交
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

        /// <summary>
        /// 模版脚本是否发生变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptChange")]
        public bool? ScriptChange{ get; set; }

        /// <summary>
        /// 代码模版脚本，base64编码返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CodeTemplateName", this.CodeTemplateName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "CodeTemplateDesc", this.CodeTemplateDesc);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "InChargeId", this.InChargeId);
            this.SetParamObj(map, prefix + "Ext.", this.Ext);
            this.SetParamSimple(map, prefix + "CodeTemplateId", this.CodeTemplateId);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "UpdateUser", this.UpdateUser);
            this.SetParamSimple(map, prefix + "UpdateUserId", this.UpdateUserId);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "Submit", this.Submit);
            this.SetParamSimple(map, prefix + "ScriptChange", this.ScriptChange);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

