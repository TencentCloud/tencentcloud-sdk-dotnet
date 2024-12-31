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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称，可选值包括 hunyuan-lite、hunyuan-standard、hunyuan-standard-256K、hunyuan-pro、 hunyuan-code、 hunyuan-role、 hunyuan-functioncall、 hunyuan-vision、 hunyuan-turbo、 hunyuan-turbo-latest、 hunyuan-large、 hunyuan-large-longcontext、 hunyuan-turbo-vision。
        /// 各模型介绍请阅读 [产品概述](https://cloud.tencent.com/document/product/1729/104753) 中的说明。
        /// 
        /// 注意：
        /// 不同的模型计费不同，请根据 [购买指南](https://cloud.tencent.com/document/product/1729/97731) 按需调用。
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 聊天上下文信息。
        /// 说明：
        /// 1. 长度最多为 40，按对话时间从旧到新在数组中排列。
        /// 2. Message.Role 可选值：system、user、assistant、 tool（functioncall场景）。
        /// 其中，system 角色可选，如存在则必须位于列表的最开始。user（tool） 和 assistant 需交替出现（一问一答），以 user 提问开始，user（tool）提问结束，其中tool可以连续出现多次，且 Content 不能为空。Role 的顺序示例：[system（可选） user assistant user（tool tool ...） assistant user（tool tool ...） ...]。
        /// 3. Messages 中 Content 总长度不能超过模型输入长度上限（可参考 [产品概述](https://cloud.tencent.com/document/product/1729/104753) 文档），超过则会截断最前面的内容，只保留尾部内容。
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// 流式调用开关。
        /// 说明：
        /// 1. 未传值时默认为非流式调用（false）。
        /// 2. 流式调用时以 SSE 协议增量返回结果（返回值取 Choices[n].Delta 中的值，需要拼接增量数据才能获得完整结果）。
        /// 3. 非流式调用时：
        /// 调用方式与普通 HTTP 请求无异。
        /// 接口响应耗时较长，**如需更低时延建议设置为 true**。
        /// 只返回一次最终结果（返回值取 Choices[n].Message 中的值）。
        /// 
        /// 注意：
        /// 通过 SDK 调用时，流式和非流式调用需用**不同的方式**获取返回值，具体参考 SDK 中的注释或示例（在各语言 SDK 代码仓库的 examples/hunyuan/v20230901/ 目录中）。
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// 流式输出审核开关。
        /// 说明：
        /// 1. 当使用流式输出（Stream 字段值为 true）时，该字段生效。
        /// 2. 输出审核有流式和同步两种模式，**流式模式首包响应更快**。未传值时默认为流式模式（true）。
        /// 3. 如果值为 true，将对输出内容进行分段审核，审核通过的内容流式输出返回。如果出现审核不过，响应中的 FinishReason 值为 sensitive。
        /// 4. 如果值为 false，则不使用流式输出审核，需要审核完所有输出内容后再返回结果。
        /// 
        /// 注意：
        /// 当选择流式输出审核时，可能会出现部分内容已输出，但中间某一段响应中的 FinishReason 值为 sensitive，此时说明安全审核未通过。如果业务场景有实时文字上屏的需求，需要自行撤回已上屏的内容，并建议自定义替换为一条提示语，如 “这个问题我不方便回答，不如我们换个话题试试”，以保障终端体验。
        /// </summary>
        [JsonProperty("StreamModeration")]
        public bool? StreamModeration{ get; set; }

        /// <summary>
        /// 说明：
        /// 1. 影响输出文本的多样性。模型已有默认参数，不传值时使用各模型推荐值，不推荐用户修改。
        /// 2. 取值区间为 [0.0, 1.0]。取值越大，生成文本的多样性越强。
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 说明：
        /// 1. 影响模型输出多样性，模型已有默认参数，不传值时使用各模型推荐值，不推荐用户修改。
        /// 2. 取值区间为 [0.0, 2.0]。较高的数值会使输出更加多样化和不可预测，而较低的数值会使其更加集中和确定。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 功能增强（如搜索）开关。
        /// 说明：
        /// 1. hunyuan-lite 无功能增强（如搜索）能力，该参数对 hunyuan-lite 版本不生效。
        /// 2. 未传值时默认打开开关。
        /// 3. 关闭时将直接由主模型生成回复内容，可以降低响应时延（对于流式输出时的首字时延尤为明显）。但在少数场景里，回复效果可能会下降。
        /// 4. 安全审核能力不属于功能增强范围，不受此字段影响。
        /// </summary>
        [JsonProperty("EnableEnhancement")]
        public bool? EnableEnhancement{ get; set; }

        /// <summary>
        /// 可调用的工具列表，仅对 hunyuan-pro、hunyuan-turbo、hunyuan-functioncall 模型生效。
        /// </summary>
        [JsonProperty("Tools")]
        public Tool[] Tools{ get; set; }

        /// <summary>
        /// 工具使用选项，可选值包括 none、auto、custom。
        /// 说明：
        /// 1. 仅对 hunyuan-pro、hunyuan-turbo、hunyuan-functioncall 模型生效。
        /// 2. none：不调用工具；auto：模型自行选择生成回复或调用工具；custom：强制模型调用指定的工具。
        /// 3. 未设置时，默认值为auto
        /// </summary>
        [JsonProperty("ToolChoice")]
        public string ToolChoice{ get; set; }

        /// <summary>
        /// 强制模型调用指定的工具，当参数ToolChoice为custom时，此参数为必填
        /// </summary>
        [JsonProperty("CustomTool")]
        public Tool CustomTool{ get; set; }

        /// <summary>
        /// 默认是false，在值为true且命中搜索时，接口会返回SearchInfo
        /// </summary>
        [JsonProperty("SearchInfo")]
        public bool? SearchInfo{ get; set; }

        /// <summary>
        /// 搜索引文角标开关。
        /// 说明：
        /// 1. 配合EnableEnhancement和SearchInfo参数使用。打开后，回答中命中搜索的结果会在片段后增加角标标志，对应SearchInfo列表中的链接。
        /// 2. false：开关关闭，true：开关打开。
        /// 3. 未传值时默认开关关闭（false）。
        /// </summary>
        [JsonProperty("Citation")]
        public bool? Citation{ get; set; }

        /// <summary>
        /// 是否开启极速版搜索，默认false，不开启；在开启且命中搜索时，会启用极速版搜索，流式输出首字返回更快。
        /// </summary>
        [JsonProperty("EnableSpeedSearch")]
        public bool? EnableSpeedSearch{ get; set; }

        /// <summary>
        /// 多媒体开关。
        /// 详细介绍请阅读 [多媒体介绍](https://cloud.tencent.com/document/product/1729/111178) 中的说明。
        /// 说明：
        /// 1. 该参数目前仅对白名单内用户生效，如您想体验该功能请 [联系我们](https://cloud.tencent.com/act/event/Online_service)。
        /// 2. 该参数仅在功能增强（如搜索）开关开启（EnableEnhancement=true）并且极速版搜索开关关闭（EnableSpeedSearch=false）时生效。
        /// 3. hunyuan-lite 无多媒体能力，该参数对 hunyuan-lite 版本不生效。
        /// 4. 未传值时默认关闭。
        /// 5. 开启并搜索到对应的多媒体信息时，会输出对应的多媒体地址，可以定制个性化的图文消息。
        /// </summary>
        [JsonProperty("EnableMultimedia")]
        public bool? EnableMultimedia{ get; set; }

        /// <summary>
        /// 是否开启深度研究该问题，默认是false，在值为true且命中深度研究该问题时，会返回深度研究该问题信息。
        /// </summary>
        [JsonProperty("EnableDeepSearch")]
        public bool? EnableDeepSearch{ get; set; }

        /// <summary>
        /// 说明： 1. 确保模型的输出是可复现的。 2. 取值区间为非0正整数，最大值10000。 3. 非必要不建议使用，不合理的取值会影响效果。
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// 强制搜索增强开关。
        /// 说明：
        /// 1. 未传值时默认关闭。
        /// 2. 开启后，将强制走AI搜索，当AI搜索结果为空时，由大模型回复兜底话术。
        /// </summary>
        [JsonProperty("ForceSearchEnhancement")]
        public bool? ForceSearchEnhancement{ get; set; }

        /// <summary>
        /// 自定义结束生成字符串
        /// </summary>
        [JsonProperty("Stop")]
        public string[] Stop{ get; set; }

        /// <summary>
        /// 推荐问答开关。
        /// 说明：
        /// 1. 未传值时默认关闭。
        /// 2. 开启后，在返回值的最后一个包中会增加 RecommendedQuestions 字段表示推荐问答， 最多返回3条。
        /// </summary>
        [JsonProperty("EnableRecommendedQuestions")]
        public bool? EnableRecommendedQuestions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "StreamModeration", this.StreamModeration);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "EnableEnhancement", this.EnableEnhancement);
            this.SetParamArrayObj(map, prefix + "Tools.", this.Tools);
            this.SetParamSimple(map, prefix + "ToolChoice", this.ToolChoice);
            this.SetParamObj(map, prefix + "CustomTool.", this.CustomTool);
            this.SetParamSimple(map, prefix + "SearchInfo", this.SearchInfo);
            this.SetParamSimple(map, prefix + "Citation", this.Citation);
            this.SetParamSimple(map, prefix + "EnableSpeedSearch", this.EnableSpeedSearch);
            this.SetParamSimple(map, prefix + "EnableMultimedia", this.EnableMultimedia);
            this.SetParamSimple(map, prefix + "EnableDeepSearch", this.EnableDeepSearch);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "ForceSearchEnhancement", this.ForceSearchEnhancement);
            this.SetParamArraySimple(map, prefix + "Stop.", this.Stop);
            this.SetParamSimple(map, prefix + "EnableRecommendedQuestions", this.EnableRecommendedQuestions);
        }
    }
}

