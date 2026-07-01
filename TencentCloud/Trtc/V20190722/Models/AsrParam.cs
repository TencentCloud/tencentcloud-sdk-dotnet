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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsrParam : AbstractModel
    {
        
        /// <summary>
        /// <p>转录服务使用的模型类型。示例值&quot;bigmodel-zh&quot;。语音转文本不同套餐版本支持的语言如下：</p><ol><li>V2版本(优先推荐)</li></ol><p>&quot;bigmodel-xxx&quot; ：大模型引擎，推荐使用。&quot;xxx&quot;填写具体语言，例如&quot;bigmodel-zh&quot;。&quot;xxx&quot;可以填写中文 (&quot;zh&quot;)，英语 (&quot;en&quot;)，粤语 (&quot;yue&quot;)，阿拉伯语 (&quot;ar&quot;)，德语 (&quot;de&quot;)，法语 (&quot;fr&quot;)，西班牙语 (&quot;es&quot;)，葡萄牙语 (&quot;pt&quot;)，印度尼西亚语 (&quot;id&quot;)，意大利语 (&quot;it&quot;)，韩语 (&quot;ko&quot;)，俄语 (&quot;ru&quot;)，泰语 (&quot;th&quot;)，越南语 (&quot;vi&quot;)，日语 (&quot;ja&quot;)，土耳其语 (&quot;tr&quot;)，印地语 (&quot;hi&quot;)，马来语 (&quot;ms&quot;)，荷兰语 (&quot;nl&quot;)，瑞典语 (&quot;sv&quot;)，丹麦语 (&quot;da&quot;)，芬兰语 (&quot;fi&quot;)，波兰语 (&quot;pl&quot;)，捷克语 (&quot;cs&quot;)，菲律宾语 (&quot;fil&quot;)，波斯语 (&quot;fa&quot;)，希腊语 (&quot;el&quot;)，匈牙利语 (&quot;hu&quot;)，马其顿语 (&quot;mk&quot;)，罗马尼亚语 (&quot;ro&quot;)。</p><ol start="2"><li>V1版本(旧版)</li></ol><p>标准语言引擎：</p><ul><li>&quot;16k_zh_large&quot;: 16k 大模型引擎，同时支持中文、英文、多种中文方言口音等语言的识别。</li><li>&quot;16k_zh_en&quot;: 最新 16k 中英大模型引擎，同时支持中文、英语、多种中文方言口音的识别，对中英混说场景识别更优。</li></ul><p>高级语言引擎：</p><ul><li>&quot;zh-yue&quot;: 中文粤语</li><li>&quot;vi&quot;: 越南语</li><li>&quot;ja&quot;: 日语</li><li>&quot;ko&quot;: 韩语</li><li>&quot;id&quot;: 印度尼西亚语</li><li>&quot;th&quot;: 泰语</li><li>&quot;pt&quot;: 葡萄牙语</li><li>&quot;tr&quot;: 土耳其语</li><li>&quot;ar&quot;: 阿拉伯语</li><li>&quot;es&quot;: 西班牙语</li><li>&quot;hi&quot;: 印地语</li><li>&quot;fr&quot;: 法语</li><li>&quot;ms&quot;: 马来语</li><li>&quot;fil&quot;: 菲律宾语</li><li>&quot;de&quot;: 德语</li><li>&quot;it&quot;: 意大利语</li><li>&quot;ru&quot;: 俄语</li><li>&quot;sv&quot;: 瑞典语</li><li>&quot;da&quot;: 丹麦语</li><li>&quot;no&quot;: 挪威语</li></ul><p>注意：<br>如果缺少满足您需求的语言，请联系我们技术人员。</p>
        /// </summary>
        [JsonProperty("Lang")]
        public string Lang{ get; set; }

        /// <summary>
        /// <p>语音识别vad的时间，范围为240-2000，默认为1000，单位为ms。更小的值会让语音识别分句更快。<br>示例值：1000</p>
        /// </summary>
        [JsonProperty("VadSilenceTime")]
        public ulong? VadSilenceTime{ get; set; }

        /// <summary>
        /// <p>临时热词表：该参数用于提升识别准确率。</p><ul><li>单个热词限制：&quot;热词|权重&quot;，单个热词不超过30个字符（最多10个汉字），权重[1-11]或者100，如：&quot;腾讯云|5&quot; 或 &quot;ASR|11&quot;。</li><li>临时热词表限制：多个热词用英文逗号分割，最多支持128个热词，如：&quot;腾讯云|10,语音识别|5,ASR|11&quot;。<br>注意：<br>热词权重设置为11时，当前热词将升级为超级热词，建议仅将重要且必须生效的热词设置到11，设置过多权重为11的热词将影响整体字准率。<br>热词权重设置为100时，当前热词开启热词增强同音同调替换功能，举例：热词配置&quot;蜜制|100&quot;时，与&quot;蜜制&quot;同拼音（mizhi）的&quot;秘制&quot;的识别结果会被强制替换成&quot;蜜制&quot;。因此建议客户根据自己的实际情况开启该功能。建议仅将重要且必须生效的热词设置到100，设置过多权重为100的热词将影响整体字准率。<br>热词不能包含空格，如：ASR 腾讯云<br>示例值：语音助理|10</li></ul>
        /// </summary>
        [JsonProperty("HotWordList")]
        public string HotWordList{ get; set; }

        /// <summary>
        /// <p>发起模糊识别为高级语言引擎能力, 仅支持填写除&quot;zh-dialect&quot;和&quot;zh-yue&quot;以外的高级语言引擎。注意：最多只能填写4种语言。</p>
        /// </summary>
        [JsonProperty("AlternativeLanguage")]
        public string[] AlternativeLanguage{ get; set; }

        /// <summary>
        /// <p>vad的远场人声抑制能力（不会对asr识别效果造成影响），范围为[0, 3]，默认为0。推荐设置为2，有较好的远场人声抑制能力。</p>
        /// </summary>
        [JsonProperty("VadLevel")]
        public ulong? VadLevel{ get; set; }

        /// <summary>
        /// <p>是否过滤脏词（目前仅支持填写基础语言引擎和标准语言引擎），范围为[0, 2]，默认值为 0。<br>0：不过滤脏词；1：过滤脏词；2：将脏词替换为 &quot; * &quot;。</p>
        /// </summary>
        [JsonProperty("FilterDirty")]
        public ulong? FilterDirty{ get; set; }

        /// <summary>
        /// <p>是否过滤语气词（目前仅支持填写基础语言引擎和标准语言引擎），范围为[0, 2]，默认值为 0。<br>0：不过滤语气词；1：部分过滤；2：严格过滤。</p>
        /// </summary>
        [JsonProperty("FilterModal")]
        public ulong? FilterModal{ get; set; }

        /// <summary>
        /// <p>是否过滤句末的句号（目前仅支持填写基础语言引擎和标准语言引擎），范围为[0, 1]，默认值为 0。<br>0：不过滤句末的句号；1：过滤句末的句号。</p>
        /// </summary>
        [JsonProperty("FilterPunc")]
        public ulong? FilterPunc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
            this.SetParamSimple(map, prefix + "VadSilenceTime", this.VadSilenceTime);
            this.SetParamSimple(map, prefix + "HotWordList", this.HotWordList);
            this.SetParamArraySimple(map, prefix + "AlternativeLanguage.", this.AlternativeLanguage);
            this.SetParamSimple(map, prefix + "VadLevel", this.VadLevel);
            this.SetParamSimple(map, prefix + "FilterDirty", this.FilterDirty);
            this.SetParamSimple(map, prefix + "FilterModal", this.FilterModal);
            this.SetParamSimple(map, prefix + "FilterPunc", this.FilterPunc);
        }
    }
}

