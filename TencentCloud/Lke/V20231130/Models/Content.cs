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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Content : AbstractModel
    {
        
        /// <summary>
        /// <p>消息内容类型<br>text：文本<br>image：图片<br>file：文件<br>option_cards：选项卡<br>custom_params：用户自定义业务参数<br>sandbox：云桌面<br>custom_variables：自定义输入参数<br>web_search: 网页搜索内容<br>file_collection：文件收集信息<br>widget：widget信息<br>widget_action：用户端widget动作信息</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>文本内容</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>引用信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuoteInfos")]
        public QuoteInfo[] QuoteInfos{ get; set; }

        /// <summary>
        /// <p>参考文献信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("References")]
        public ContentReference[] References{ get; set; }

        /// <summary>
        /// <p>图片信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Image")]
        public ImageInfoContent Image{ get; set; }

        /// <summary>
        /// <p>文件信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("File")]
        public FileInfoContent File{ get; set; }

        /// <summary>
        /// <p>选项卡信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptionCards")]
        public string[] OptionCards{ get; set; }

        /// <summary>
        /// <p>用户自定义业务参数信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomParams")]
        public string[] CustomParams{ get; set; }

        /// <summary>
        /// <p>自定义变量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomVariables")]
        public string[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>沙盒信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sandbox")]
        public SandboxContent Sandbox{ get; set; }

        /// <summary>
        /// <p>网页搜索内容</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebSearch")]
        public WebSearchContent WebSearch{ get; set; }

        /// <summary>
        /// <p>文件收集信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileCollection")]
        public FileCollection FileCollection{ get; set; }

        /// <summary>
        /// <p>Widget信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Widget")]
        public Widget Widget{ get; set; }

        /// <summary>
        /// <p>Widget动作信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WidgetAction")]
        public WidgetAction WidgetAction{ get; set; }

        /// <summary>
        /// <p>任务列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public AgentTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>问卷信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Questionnaire")]
        public Questionnaire Questionnaire{ get; set; }

        /// <summary>
        /// <p>选项卡模式</p>
        /// </summary>
        [JsonProperty("OptionMode")]
        public long? OptionMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamArrayObj(map, prefix + "QuoteInfos.", this.QuoteInfos);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamObj(map, prefix + "File.", this.File);
            this.SetParamArraySimple(map, prefix + "OptionCards.", this.OptionCards);
            this.SetParamArraySimple(map, prefix + "CustomParams.", this.CustomParams);
            this.SetParamArraySimple(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamObj(map, prefix + "Sandbox.", this.Sandbox);
            this.SetParamObj(map, prefix + "WebSearch.", this.WebSearch);
            this.SetParamObj(map, prefix + "FileCollection.", this.FileCollection);
            this.SetParamObj(map, prefix + "Widget.", this.Widget);
            this.SetParamObj(map, prefix + "WidgetAction.", this.WidgetAction);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamObj(map, prefix + "Questionnaire.", this.Questionnaire);
            this.SetParamSimple(map, prefix + "OptionMode", this.OptionMode);
        }
    }
}

