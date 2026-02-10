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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatTranslationsRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称，可选值包括 hunyuan-translation、hunyuan-translation-lite。
        /// 各模型介绍请阅读 [产品概述](https://cloud.tencent.com/document/product/1729/104753) 中的说明。
        /// 
        /// 注意：
        /// 不同的模型计费不同，请根据 [购买指南](https://cloud.tencent.com/document/product/1729/97731) 按需调用。
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

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
        /// 待翻译的文本
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 源语言。
        /// 支持语言列表: 
        /// 简体中文：zh，繁体中文：zh-TR，粤语：yue，英语：en，法语：fr，葡萄牙语：pt，西班牙语：es，日语：ja，土耳其语：tr，俄语：ru，阿拉伯语：ar，韩语：ko，泰语：th，意大利语：it，德语：de，越南语：vi，马来语：ms，印尼语：id
        /// 以下语种仅 hunyuan-translation 模型支持：
        /// 菲律宾语：fil，印地语：hi，波兰语：pl，捷克语：cs，荷兰语：nl，高棉语：km，缅甸语：my，波斯语：fa，古吉拉特语：gu，乌尔都语：ur，泰卢固语：te，马拉地语：mr，希伯来语：he，孟加拉语：bn，泰米尔语：ta，乌克兰语：uk，藏语：bo，哈萨克语：kk，蒙古语：mn，维吾尔语：ug
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 目标语言。
        /// 支持语言列表: 
        /// 简体中文：zh，繁体中文：zh-TR，粤语：yue，英语：en，法语：fr，葡萄牙语：pt，西班牙语：es，日语：ja，土耳其语：tr，俄语：ru，阿拉伯语：ar，韩语：ko，泰语：th，意大利语：it，德语：de，越南语：vi，马来语：ms，印尼语：id
        /// 以下语种仅 hunyuan-translation 模型支持：
        /// 菲律宾语：fil，印地语：hi，波兰语：pl，捷克语：cs，荷兰语：nl，高棉语：km，缅甸语：my，波斯语：fa，古吉拉特语：gu，乌尔都语：ur，泰卢固语：te，马拉地语：mr，希伯来语：he，孟加拉语：bn，泰米尔语：ta，乌克兰语：uk，藏语：bo，哈萨克语：kk，蒙古语：mn，维吾尔语：ug
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 待翻译文本所属领域，例如游戏剧情等
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 参考示例，最多10个
        /// </summary>
        [JsonProperty("References")]
        public Reference[] References{ get; set; }

        /// <summary>
        /// 关联的术语库 ID 列表，用于术语翻译，最大支持5个术语库
        /// </summary>
        [JsonProperty("GlossaryIDs")]
        public string[] GlossaryIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamArraySimple(map, prefix + "GlossaryIDs.", this.GlossaryIDs);
        }
    }
}

