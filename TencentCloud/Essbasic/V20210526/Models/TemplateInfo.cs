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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板ID，模板的唯一标识
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 模板名
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 模板描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 模板的填充控件列表
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

        /// <summary>
        /// 此模块需要签署的各个参与方的角色列表。RecipientId标识每个参与方角色对应的唯一标识符，用于确定此角色的信息。
        /// </summary>
        [JsonProperty("Recipients")]
        public Recipient[] Recipients{ get; set; }

        /// <summary>
        /// 此模版中的签署控件列表
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// 模板类型：1-静默签；3-普通模板
        /// </summary>
        [JsonProperty("TemplateType")]
        public long? TemplateType{ get; set; }

        /// <summary>
        /// 是否是发起人 ,已弃用
        /// </summary>
        [JsonProperty("IsPromoter")]
        [System.Obsolete]
        public bool? IsPromoter{ get; set; }

        /// <summary>
        /// 模板的创建者信息，电子签系统用户ID
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 模板创建的时间戳，格式为Unix标准时间戳（秒）
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 模板的H5预览链接,有效期5分钟。
        /// 可以通过浏览器打开此链接预览模板，或者嵌入到iframe中预览模板。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }

        /// <summary>
        /// 第三方应用集成-模板PDF文件链接，有效期5分钟。
        /// 请求参数WithPdfUrl=true时返回
        /// （此功能开放需要联系客户经理）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PdfUrl")]
        public string PdfUrl{ get; set; }

        /// <summary>
        /// 本模板关联的第三方应用平台企业模板ID
        /// </summary>
        [JsonProperty("ChannelTemplateId")]
        public string ChannelTemplateId{ get; set; }

        /// <summary>
        /// 本模板关联的三方应用平台平台企业模板名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelTemplateName")]
        public string ChannelTemplateName{ get; set; }

        /// <summary>
        /// 0-需要子客企业手动领取平台企业的模板(默认); 
        /// 1-平台自动设置子客模板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelAutoSave")]
        public long? ChannelAutoSave{ get; set; }

        /// <summary>
        /// 模板版本，由全数字字符组成。
        /// 默认为空，模板版本号由日期和序号组成，初始版本为yyyyMMdd001，yyyyMMdd002表示第二个版本，以此类推。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateVersion")]
        public string TemplateVersion{ get; set; }

        /// <summary>
        /// 模板可用状态的取值通常为以下两种：
        /// 
        /// <ul><li>1：启用（默认），表示模板处于启用状态，可以被用户正常使用。</li>
        /// <li>2：停用，表示模板处于停用状态，禁止用户使用该模板。</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Available")]
        public long? Available{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamArrayObj(map, prefix + "Recipients.", this.Recipients);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "IsPromoter", this.IsPromoter);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamSimple(map, prefix + "PdfUrl", this.PdfUrl);
            this.SetParamSimple(map, prefix + "ChannelTemplateId", this.ChannelTemplateId);
            this.SetParamSimple(map, prefix + "ChannelTemplateName", this.ChannelTemplateName);
            this.SetParamSimple(map, prefix + "ChannelAutoSave", this.ChannelAutoSave);
            this.SetParamSimple(map, prefix + "TemplateVersion", this.TemplateVersion);
            this.SetParamSimple(map, prefix + "Available", this.Available);
        }
    }
}

