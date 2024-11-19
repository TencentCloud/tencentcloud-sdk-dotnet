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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRecTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎模型类型
        /// 识别引擎采用分级计费方案，标记为“大模型版”的引擎适用大模型计费方案，[点击这里](https://cloud.tencent.com/document/product/1093/35686) 查看产品计费说明
        /// 
        /// 电话通讯场景引擎：
        /// **注意：电话通讯场景，请务必使用以下8k引擎**
        /// • 8k_zh：中文电话通讯；
        /// • 8k_en：英文电话通讯；
        /// • **8k_zh_large：**普方大模型引擎【大模型版】。当前模型同时支持中文、[多种中文方言](https://cloud.tencent.com/document/product/1093/35682)等语言的识别，模型参数量极大，语言模型性能增强，针对电话音频中各类场景、各类中文方言的识别准确率极大提升，[点击这里](https://console.cloud.tencent.com/asr/demonstrate) 对比常规版本与普方大模型版本的识别效果；
        /// 
        /// 注意：如您有电话通讯场景识别需求，但发现需求语种仅支持16k，可将8k音频传入下方16k引擎，亦能获取识别结果。但**16k引擎并非基于电话通讯数据训练，无法承诺此种调用方式的识别效果，需由您自行验证识别结果是否可用**
        /// 
        /// 通用场景引擎：
        /// **注意：除电话通讯场景以外的其它识别场景，请务必使用以下16k引擎**
        /// • **16k_zh：**中文普通话通用引擎，支持中文普通话和少量英语，使用丰富的中文普通话语料训练，覆盖场景广泛，适用于除电话通讯外的所有中文普通话识别场景；
        /// • **16k_zh_large：**普方英大模型引擎【大模型版】。当前模型同时支持中文、英文、[多种中文方言](https://cloud.tencent.com/document/product/1093/35682)等语言的识别，模型参数量极大，语言模型性能增强，针对噪声大、回音大、人声小、人声远等低质量音频的识别准确率极大提升，[点击这里](https://console.cloud.tencent.com/asr/demonstrate) 对比中文普通话常规版本与普方英大模型版本的识别效果；
        /// • **16k_multi_lang：**多语种大模型引擎【大模型版】。当前模型同时支持英语、日语、韩语、阿拉伯语、菲律宾语、法语、印地语、印尼语、马来语、葡萄牙语、西班牙语、泰语、土耳其语、越南语、德语的识别，可实现15个语种的自动识别(句子/段落级别)；
        /// • **16k_zh_dialect：**中文普通话+多方言混合引擎，除普通话外支持23种方言（上海话、四川话、武汉话、贵阳话、昆明话、西安话、郑州话、太原话、兰州话、银川话、西宁话、南京话、合肥话、南昌话、长沙话、苏州话、杭州话、济南话、天津话、石家庄话、黑龙江话、吉林话、辽宁话）；
        /// • **16k_en：**英语；
        /// • **16k_yue：**粤语；
        /// • **16k_zh-PY：**中英粤混合引擎，使用一个引擎同时识别中文普通话、英语、粤语三个语言;
        /// • **16k_ja：**日语；
        /// • **16k_ko：**韩语；
        /// • **16k_vi：**越南语；
        /// • **16k_ms：**马来语；
        /// • **16k_id：**印度尼西亚语；
        /// • **16k_fil：**菲律宾语；
        /// • **16k_th：**泰语；
        /// • **16k_pt：**葡萄牙语；
        /// • **16k_tr：**土耳其语；
        /// • **16k_ar：**阿拉伯语；
        /// • **16k_es：**西班牙语；
        /// • **16k_hi：**印地语；
        /// • **16k_fr：**法语；
        /// • **16k_zh_medical：**中文医疗引擎；
        /// • **16k_de：**德语；
        /// </summary>
        [JsonProperty("EngineModelType")]
        public string EngineModelType{ get; set; }

        /// <summary>
        /// 识别声道数
        /// 1：单声道（16k音频仅支持单声道，**请勿**设置为双声道）；
        /// 2：双声道（仅支持8k电话音频，且双声道应分别为通话双方）
        /// 
        /// 注意：
        /// • 16k音频：仅支持单声道识别，**需设置ChannelNum=1**；
        /// • 8k电话音频：支持单声道、双声道识别，**建议设置ChannelNum=2，即双声道**。双声道能够物理区分说话人、避免说话双方重叠产生的识别错误，能达到最好的说话人分离效果和识别效果。设置双声道后，将自动区分说话人，因此**无需再开启说话人分离功能**，相关参数（**SpeakerDiarization、SpeakerNumber**）使用默认值即可，返回的ResultDetail中的speakerId的值为0代表左声道，值为1代表右声道。
        /// </summary>
        [JsonProperty("ChannelNum")]
        public ulong? ChannelNum{ get; set; }

        /// <summary>
        /// 识别结果返回样式
        /// 0：基础识别结果（仅包含有效人声时间戳，无词粒度的[详细识别结果](https://cloud.tencent.com/document/api/1093/37824#SentenceDetail)）；
        /// 1：基础识别结果之上，增加词粒度的[详细识别结果](https://cloud.tencent.com/document/api/1093/37824#SentenceDetail)（包含词级别时间戳、语速值，**不含标点**）；
        /// 2：基础识别结果之上，增加词粒度的[详细识别结果](https://cloud.tencent.com/document/api/1093/37824#SentenceDetail)（包含词级别时间戳、语速值和标点）；
        /// 3：基础识别结果之上，增加词粒度的[详细识别结果](https://cloud.tencent.com/document/api/1093/37824#SentenceDetail)（包含词级别时间戳、语速值和标点），且识别结果按标点符号分段，**适用字幕场景**；
        /// 4：**【增值付费功能】**基础识别结果之上，增加词粒度的[详细识别结果](https://cloud.tencent.com/document/api/1093/37824#SentenceDetail)（包含词级别时间戳、语速值和标点），且识别结果按nlp语义分段，**适用会议、庭审记录转写等场景**，仅支持8k_zh/16k_zh引擎
        /// 5：**【增值付费功能】**基础识别结果之上，增加词粒度的[详细识别结果](https://cloud.tencent.com/document/api/1093/37824#SentenceDetail)（包含词级别时间戳、语速值和标点），并输出口语转书面语转写结果，该结果去除语气词、重复词、精简冗余表达，并修正发言人口误，实现口语转书面语的效果，**适用于线上、线下会议直接总结为书面会议纪要的场景**，仅支持8k_zh/16k_zh引擎
        /// 
        /// 注意：
        /// 如果传入参数值4，需确保账号已购买[语义分段资源包](https://cloud.tencent.com/document/product/1093/35686#97ae4aa0-29a0-4066-9f07-ccaf8856a16b)，或账号开启后付费；**若当前账号已开启后付费功能，并传入参数值4，将[自动计费](https://cloud.tencent.com/document/product/1093/35686#d912167d-ffd5-41a9-8b1c-2e89845a6852)**
        /// 如果传入参数值5，需确保账号已购买[口语转书面语资源包](https://cloud.tencent.com/document/product/1093/35686#97ae4aa0-29a0-4066-9f07-ccaf8856a16b)，或账号开启后付费；**若当前账号已开启后付费功能，并传入参数值5，将自动计费[自动计费](https://cloud.tencent.com/document/product/1093/35686#d912167d-ffd5-41a9-8b1c-2e89845a6852)**
        /// </summary>
        [JsonProperty("ResTextFormat")]
        public ulong? ResTextFormat{ get; set; }

        /// <summary>
        /// 音频数据来源
        /// 0：音频URL；
        /// 1：音频数据（post body）
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 音频数据base64编码
        /// **当 SourceType 值为 1 时须填写该字段，为 0 时不需要填写**
        /// 
        /// 注意：音频数据要小于5MB（含）
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 数据长度（此数据长度为数据未进行base64编码时的长度）
        /// </summary>
        [JsonProperty("DataLen")]
        public ulong? DataLen{ get; set; }

        /// <summary>
        /// 音频URL的地址（需要公网环境浏览器可下载）
        /// **当 SourceType 值为 0 时须填写该字段，为 1 时不需要填写**
        /// 
        /// 注意：
        /// 1. 请确保录音文件时长在5个小时（含）之内，否则可能识别失败；
        /// 2. 请保证文件的下载速度，否则可能下载失败
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 回调 URL
        /// 用户自行搭建的用于接收识别结果的服务URL
        /// 回调格式和内容详见：[录音识别回调说明](https://cloud.tencent.com/document/product/1093/52632)
        /// 
        /// 注意：
        /// 
        /// - 如果用户使用轮询方式获取识别结果，则无需提交该参数
        /// - 建议在回调URL中带上您的业务ID等信息，以便处理业务逻辑
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 是否开启说话人分离
        /// 0：不开启；
        /// 1：开启（仅支持以下引擎：8k_zh/16k_zh/16k_ms/16k_en/16k_id/16k_zh_large/16k_zh_dialect，且ChannelNum=1时可用）；
        /// 默认值为 0
        /// 
        /// 注意：
        /// 8k双声道电话音频请按 **ChannelNum 识别声道数** 的参数描述使用默认值
        /// </summary>
        [JsonProperty("SpeakerDiarization")]
        public long? SpeakerDiarization{ get; set; }

        /// <summary>
        /// 说话人分离人数
        /// **需配合开启说话人分离使用，不开启无效**，取值范围：0-10
        /// 0：自动分离（最多分离出20个人）；
        /// 1-10：指定人数分离；
        /// 默认值为 0
        /// </summary>
        [JsonProperty("SpeakerNumber")]
        public long? SpeakerNumber{ get; set; }

        /// <summary>
        /// 热词表id
        /// 如不设置该参数，将自动生效默认热词表；
        /// 如设置该参数，将生效对应id的热词表；
        /// 点击这里查看[热词表配置方法](https://cloud.tencent.com/document/product/1093/40996)
        /// </summary>
        [JsonProperty("HotwordId")]
        public string HotwordId{ get; set; }

        /// <summary>
        /// 热词增强功能（目前仅支持8k_zh/16k_zh引擎）
        /// 1：开启热词增强功能
        /// 
        /// 注意：热词增强功能开启后，将对传入的热词表id开启同音替换功能，可以在这里查看[热词表配置方法](https://cloud.tencent.com/document/product/1093/40996)。效果举例：在热词表中配置“蜜制”一词，并开启增强功能，与“蜜制”（mìzhì）同音同调的“秘制”（mìzhì）的识别结果会被强制替换成“蜜制”。**建议客户根据实际的业务需求开启该功能**
        /// </summary>
        [JsonProperty("ReinforceHotword")]
        [System.Obsolete]
        public long? ReinforceHotword{ get; set; }

        /// <summary>
        /// 自学习定制模型 id
        /// 如设置了该参数，将生效对应id的自学习定制模型；
        /// 点击这里查看[自学习定制模型配置方法](https://cloud.tencent.com/document/product/1093/38416)
        /// </summary>
        [JsonProperty("CustomizationId")]
        public string CustomizationId{ get; set; }

        /// <summary>
        /// **【增值付费功能】**情绪识别能力（目前仅支持16k_zh,8k_zh）
        /// 0：不开启；
        /// 1：开启情绪识别，但不在文本展示情绪标签；
        /// 2：开启情绪识别，并且在文本展示情绪标签（**该功能需要设置ResTextFormat 大于0**）
        /// 默认值为0
        /// 支持的情绪分类为：高兴、伤心、愤怒
        /// 
        /// 注意：
        /// 1. **本功能为增值服务**，需将参数设置为1或2时方可按对应方式生效；
        /// 2. 如果传入参数值1或2，需确保账号已购买[情绪识别资源包](https://cloud.tencent.com/document/product/1093/35686#97ae4aa0-29a0-4066-9f07-ccaf8856a16b)，或账号开启后付费；**若当前账号已开启后付费功能，并传入参数值1或2，将[自动计费](https://cloud.tencent.com/document/product/1093/35686#d912167d-ffd5-41a9-8b1c-2e89845a6852)）**；
        /// 3. 参数设置为0时，无需购买资源包，也不会消耗情绪识别对应资源
        /// </summary>
        [JsonProperty("EmotionRecognition")]
        public long? EmotionRecognition{ get; set; }

        /// <summary>
        /// 情绪能量值
        /// 取值为音量分贝值/10，取值范围：[1,10]，值越高情绪越强烈
        /// 0：不开启；
        /// 1：开启；
        /// 默认值为0
        /// </summary>
        [JsonProperty("EmotionalEnergy")]
        public long? EmotionalEnergy{ get; set; }

        /// <summary>
        /// 阿拉伯数字智能转换（目前支持中文普通话引擎）
        /// 0：不转换，直接输出中文数字；
        /// 1：根据场景智能转换为阿拉伯数字；
        /// 3：打开数学相关数字转换（如：阿尔法转写为α）；
        /// 默认值为 1
        /// </summary>
        [JsonProperty("ConvertNumMode")]
        public long? ConvertNumMode{ get; set; }

        /// <summary>
        /// 脏词过滤（目前支持中文普通话引擎）
        /// 0：不过滤脏词；
        /// 1：过滤脏词；
        /// 2：将脏词替换为 * ；
        /// 默认值为 0
        /// </summary>
        [JsonProperty("FilterDirty")]
        public long? FilterDirty{ get; set; }

        /// <summary>
        /// 标点符号过滤（目前支持中文普通话引擎）
        /// 0：不过滤标点；
        /// 1：过滤句末标点；
        /// 2：过滤所有标点；
        /// 默认值为 0
        /// </summary>
        [JsonProperty("FilterPunc")]
        public long? FilterPunc{ get; set; }

        /// <summary>
        /// 语气词过滤（目前支持中文普通话引擎）
        /// 0：不过滤语气词；
        /// 1：过滤部分语气词；
        /// 2：严格过滤语气词；
        /// 默认值为 0
        /// </summary>
        [JsonProperty("FilterModal")]
        public long? FilterModal{ get; set; }

        /// <summary>
        /// 单标点最多字数（目前支持中文普通话引擎）
        /// **可控制单行字幕最大字数，适用于字幕生成场景**，取值范围：[6，40]
        /// 0：不开启该功能；
        /// 默认值为0
        /// 
        /// 注意：需设置ResTextFormat为3，解析返回的ResultDetail列表，通过结构中FinalSentence获取单个标点断句结果
        /// </summary>
        [JsonProperty("SentenceMaxLength")]
        public long? SentenceMaxLength{ get; set; }

        /// <summary>
        /// 附加参数**（该参数无意义，忽略即可）**
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 临时热词表：该参数用于提升识别准确率。
        /// 
        /// - 单个热词限制："热词|权重"，单个热词不超过30个字符（最多10个汉字），权重[1-11]或者100，如：“腾讯云|5” 或“ASR|11”；
        /// 
        /// - 临时热词表限制：多个热词用英文逗号分割，最多支持128个热词，如：“腾讯云|10,语音识别|5,ASR|11”；
        /// 
        /// - 参数 hotword_id（热词表） 与 hotword_list（临时热词表） 区别：
        /// 
        ///     - hotword_id：热词表。需要先在控制台或接口创建热词表，获得对应hotword_id传入参数来使用热词功能；
        /// 
        ///     - hotword_list：临时热词表。每次请求时直接传入临时热词表来使用热词功能，云端不保留临时热词表。适用于有极大量热词需求的用户；
        /// 
        /// 注意：
        /// 
        /// - 如果同时传入了 hotword_id 和 hotword_list，只有hotword_list 生效；
        /// 
        /// - 热词权重设置为11时，当前热词将升级为超级热词，建议仅将重要且必须生效的热词设置到11，设置过多权重为11的热词将影响整体字准率。
        /// 
        /// - 热词权重设置为100时，当前热词开启热词增强同音替换功能（仅支持8k_zh,16k_zh），举例：热词配置“蜜制|100”时，与“蜜制”同拼音（mizhi）的“秘制”的识别结果会被强制替换成“蜜制”。因此建议客户根据自己的实际情况开启该功能。建议仅将重要且必须生效的热词设置到100，设置过多权重为100的热词将影响整体字准率。
        /// </summary>
        [JsonProperty("HotwordList")]
        public string HotwordList{ get; set; }

        /// <summary>
        /// 关键词识别ID列表，默认空为不进行识别，最多10个
        /// </summary>
        [JsonProperty("KeyWordLibIdList")]
        public string[] KeyWordLibIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineModelType", this.EngineModelType);
            this.SetParamSimple(map, prefix + "ChannelNum", this.ChannelNum);
            this.SetParamSimple(map, prefix + "ResTextFormat", this.ResTextFormat);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "DataLen", this.DataLen);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "SpeakerDiarization", this.SpeakerDiarization);
            this.SetParamSimple(map, prefix + "SpeakerNumber", this.SpeakerNumber);
            this.SetParamSimple(map, prefix + "HotwordId", this.HotwordId);
            this.SetParamSimple(map, prefix + "ReinforceHotword", this.ReinforceHotword);
            this.SetParamSimple(map, prefix + "CustomizationId", this.CustomizationId);
            this.SetParamSimple(map, prefix + "EmotionRecognition", this.EmotionRecognition);
            this.SetParamSimple(map, prefix + "EmotionalEnergy", this.EmotionalEnergy);
            this.SetParamSimple(map, prefix + "ConvertNumMode", this.ConvertNumMode);
            this.SetParamSimple(map, prefix + "FilterDirty", this.FilterDirty);
            this.SetParamSimple(map, prefix + "FilterPunc", this.FilterPunc);
            this.SetParamSimple(map, prefix + "FilterModal", this.FilterModal);
            this.SetParamSimple(map, prefix + "SentenceMaxLength", this.SentenceMaxLength);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "HotwordList", this.HotwordList);
            this.SetParamArraySimple(map, prefix + "KeyWordLibIdList.", this.KeyWordLibIdList);
        }
    }
}

