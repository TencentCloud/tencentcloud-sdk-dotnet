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
        /// 支持语言列表: 1. 简体中文：zh，2. 粤语：yue，3. 英语：en，4. 法语：fr，5. 葡萄牙语：pt，6. 西班牙语：es，7. 日语：ja，8. 土耳其语：tr，9. 俄语：ru，10. 阿拉伯语：ar，11. 韩语：ko，12. 泰语：th，13. 意大利语：it，14. 德语：de，15. 越南语：vi，16. 马来语：ms，17. 印尼语：id
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 目标语言。
        /// 支持语言列表: 1. 简体中文：zh，2. 粤语：yue，3. 英语：en，4. 法语：fr，5. 葡萄牙语：pt，6. 西班牙语：es，7. 日语：ja，8. 土耳其语：tr，9. 俄语：ru，10. 阿拉伯语：ar，11. 韩语：ko，12. 泰语：th，13. 意大利语：it，14. 德语：de，15. 越南语：vi，16. 马来语：ms，17. 印尼语：id
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
        }
    }
}

