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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>模板ID，模板的唯一标识</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>模板的名字</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>此模块需要签署的各个参与方的角色列表。RecipientId标识每个参与方角色对应的唯一标识符，用于确定此角色的信息。</p><p><a href="https://qcloudimg.tencent-cloud.cn/raw/e082bbcc0d923f8cb723d98382410aa2.png">点击查看在模板中配置的签署参与方角色列表的样子</a></p>
        /// </summary>
        [JsonProperty("Recipients")]
        public Recipient[] Recipients{ get; set; }

        /// <summary>
        /// <p>模板的填充控件列表</p><p><a href="https://qcloudimg.tencent-cloud.cn/raw/cb2f58529fca8d909258f9d45a56f7f4.png">点击查看在模板中配置的填充控件的样子</a></p>
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

        /// <summary>
        /// <p>此模板中的签署控件列表</p><p><a href="https://qcloudimg.tencent-cloud.cn/raw/29bc6ed753a5a0fce4a3ab02e2c0d955.png">点击查看在模板中配置的签署控件的样子</a></p>
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// <p>模板描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>此模板的资源ID</p>
        /// </summary>
        [JsonProperty("DocumentResourceIds")]
        public string[] DocumentResourceIds{ get; set; }

        /// <summary>
        /// <p>生成模板的文件基础信息</p>
        /// </summary>
        [JsonProperty("FileInfos")]
        public FileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>此模板里边附件的资源ID</p>
        /// </summary>
        [JsonProperty("AttachmentResourceIds")]
        public string[] AttachmentResourceIds{ get; set; }

        /// <summary>
        /// <p>签署人参与签署的顺序，可以分为以下两种方式：</p><p><b>无序</b>：不限定签署人的签署顺序，签署人可以在任何时间签署。此种方式值为 ：｛-1｝<br><b>有序</b>：通过序列数字标识签署顺序，从0开始编码，数字越大签署顺序越靠后，签署人按照指定的顺序依次签署。此种方式值为： ｛0，1，2，3………｝</p>
        /// </summary>
        [JsonProperty("SignOrder")]
        public long?[] SignOrder{ get; set; }

        /// <summary>
        /// <p>此模板的状态可以分为以下几种：</p><p><b>-1</b>：不可用状态。<br><b>0</b>：草稿态，即模板正在编辑或未发布状态。<br><b>1</b>：正式态，只有正式态的模板才可以发起合同。</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>模板的创建者信息，用户的名字</p><p>注： <code>是创建者的名字，而非创建者的用户ID</code></p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>模板创建的时间戳，格式为Unix标准时间戳（秒）</p>
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// <p>此模板创建方角色信息。</p><p><a href="https://qcloudimg.tencent-cloud.cn/raw/e082bbcc0d923f8cb723d98382410aa2.png">点击查看在模板中配置的创建方角色的样子</a></p>
        /// </summary>
        [JsonProperty("Promoter")]
        public Recipient Promoter{ get; set; }

        /// <summary>
        /// <p>模板类型可以分为以下两种：<b>1</b>：带有本企业“授权签”的模板，即签署过程无需签署人手动操作，系统自动完成签署。<b>3</b>：普通模板，即签署人需要手动进行签署操作。</p>
        /// </summary>
        [JsonProperty("TemplateType")]
        public long? TemplateType{ get; set; }

        /// <summary>
        /// <p>模板可用状态可以分为以下两种：</p><p><b>1</b>：（默认）启用状态，即模板可以正常使用。<br><b>2</b>：停用状态，即模板暂时无法使用。</p><p>可到控制台启停模板</p>
        /// </summary>
        [JsonProperty("Available")]
        public long? Available{ get; set; }

        /// <summary>
        /// <p>创建模板的企业ID，电子签的机构ID</p>
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// <p>模板创建人用户ID</p>
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// <p>模板的 H5 预览链接，有效期为 5 分钟。<br>您可以通过浏览器直接打开此链接预览模板，或将其嵌入到 iframe 中进行预览。</p><p>注意：只有在请求接口时将 <b>WithPreviewUrl </b>参数设置为 true，才会生成预览链接。</p>
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }

        /// <summary>
        /// <p>用户自定义合同类型。</p><p>返回配置模板的时候选择的合同类型。<a href="https://qcloudimg.tencent-cloud.cn/raw/4a766f0540253bf2a05d50c58bd14990.png">点击查看配置的位置</a></p><p>自定义合同类型配置的地方如链接图所示。<a href="https://qcloudimg.tencent-cloud.cn/raw/36582cea03ae6a2559894844942b5d5c.png">点击查看自定义合同类型管理的位置</a></p>
        /// </summary>
        [JsonProperty("UserFlowType")]
        public UserFlowType UserFlowType{ get; set; }

        /// <summary>
        /// <p>模板版本的编号，旨在标识其独特的版本信息，通常呈现为一串字符串，由日期和递增的数字组成</p>
        /// </summary>
        [JsonProperty("TemplateVersion")]
        public string TemplateVersion{ get; set; }

        /// <summary>
        /// <p>模板是否已发布可以分为以下两种状态：</p><p><b>true</b>：已发布状态，表示该模板已经发布并可以正常使用。<br><b>false</b>：未发布状态，表示该模板还未发布，无法使用。</p>
        /// </summary>
        [JsonProperty("Published")]
        public bool? Published{ get; set; }

        /// <summary>
        /// <p><b>集体账号场景下</b>： 集团账号分享给子企业的模板的来源模板ID。</p>
        /// </summary>
        [JsonProperty("ShareTemplateId")]
        public string ShareTemplateId{ get; set; }

        /// <summary>
        /// <p>此模板配置的预填印章列表（包括“授权签”指定的印章）</p>
        /// </summary>
        [JsonProperty("TemplateSeals")]
        public SealInfo[] TemplateSeals{ get; set; }

        /// <summary>
        /// <p>模板内部指定的印章列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Seals")]
        [System.Obsolete]
        public SealInfo[] Seals{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamArrayObj(map, prefix + "Recipients.", this.Recipients);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "DocumentResourceIds.", this.DocumentResourceIds);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArraySimple(map, prefix + "AttachmentResourceIds.", this.AttachmentResourceIds);
            this.SetParamArraySimple(map, prefix + "SignOrder.", this.SignOrder);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamObj(map, prefix + "Promoter.", this.Promoter);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamObj(map, prefix + "UserFlowType.", this.UserFlowType);
            this.SetParamSimple(map, prefix + "TemplateVersion", this.TemplateVersion);
            this.SetParamSimple(map, prefix + "Published", this.Published);
            this.SetParamSimple(map, prefix + "ShareTemplateId", this.ShareTemplateId);
            this.SetParamArrayObj(map, prefix + "TemplateSeals.", this.TemplateSeals);
            this.SetParamArrayObj(map, prefix + "Seals.", this.Seals);
        }
    }
}

