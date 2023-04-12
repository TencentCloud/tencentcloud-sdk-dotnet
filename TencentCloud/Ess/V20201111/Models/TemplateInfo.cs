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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 模板描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 模板关联的资源IDs
        /// </summary>
        [JsonProperty("DocumentResourceIds")]
        public string[] DocumentResourceIds{ get; set; }

        /// <summary>
        /// 返回的文件信息结构
        /// </summary>
        [JsonProperty("FileInfos")]
        public FileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// 附件关联的资源ID是
        /// </summary>
        [JsonProperty("AttachmentResourceIds")]
        public string[] AttachmentResourceIds{ get; set; }

        /// <summary>
        /// 签署顺序
        /// </summary>
        [JsonProperty("SignOrder")]
        public long?[] SignOrder{ get; set; }

        /// <summary>
        /// 签署参与者的信息
        /// </summary>
        [JsonProperty("Recipients")]
        public Recipient[] Recipients{ get; set; }

        /// <summary>
        /// 模板信息结构
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

        /// <summary>
        /// 签署区模板信息结构
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// 模板状态(-1:不可用；0:草稿态；1:正式态)
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 模板的创建人
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 模板创建的时间戳（精确到秒）
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 发起人角色信息
        /// </summary>
        [JsonProperty("Promoter")]
        public Recipient Promoter{ get; set; }

        /// <summary>
        /// 模板可用状态，取值：0未知，但默认会被转成启用；1启用（默认），2停用
        /// </summary>
        [JsonProperty("Available")]
        public long? Available{ get; set; }

        /// <summary>
        /// 模板创建组织id
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 模板预览链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }

        /// <summary>
        /// 模板版本。默认为空时，全数字字符，初始版本为yyyyMMdd001。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateVersion")]
        public string TemplateVersion{ get; set; }

        /// <summary>
        /// 模板是否已发布。true-已发布；false-未发布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Published")]
        public bool? Published{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "DocumentResourceIds.", this.DocumentResourceIds);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArraySimple(map, prefix + "AttachmentResourceIds.", this.AttachmentResourceIds);
            this.SetParamArraySimple(map, prefix + "SignOrder.", this.SignOrder);
            this.SetParamArrayObj(map, prefix + "Recipients.", this.Recipients);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamObj(map, prefix + "Promoter.", this.Promoter);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamSimple(map, prefix + "TemplateVersion", this.TemplateVersion);
            this.SetParamSimple(map, prefix + "Published", this.Published);
        }
    }
}

