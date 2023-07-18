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
        /// 引擎模型类型。注意：非电话场景请务必使用16k的引擎。
        /// 电话场景：
        /// • 8k_zh：中文电话通用；
        /// • 8k_en：英文电话通用；
        /// 
        /// 非电话场景：
        /// • 16k_zh：中文通用；
        /// • 16k_zh-PY：中英粤;
        /// • 16k_zh_medical：中文医疗；
        /// • 16k_en：英语；
        /// • 16k_yue：粤语；
        /// • 16k_ja：日语；
        /// • 16k_ko：韩语；
        /// • 16k_vi：越南语；
        /// • 16k_ms：马来语；
        /// • 16k_id：印度尼西亚语；
        /// • 16k_fil：菲律宾语；
        /// • 16k_th：泰语；
        /// • 16k_pt：葡萄牙语；
        /// • 16k_tr：土耳其语；
        /// • 16k_ar：阿拉伯语；
        /// • 16k_zh_dialect：多方言，支持23种方言（上海话、四川话、武汉话、贵阳话、昆明话、西安话、郑州话、太原话、兰州话、银川话、西宁话、南京话、合肥话、南昌话、长沙话、苏州话、杭州话、济南话、天津话、石家庄话、黑龙江话、吉林话、辽宁话）；
        /// </summary>
        [JsonProperty("EngineModelType")]
        public string EngineModelType{ get; set; }

        /// <summary>
        /// 识别声道数。1：单声道（非电话场景，直接选择单声道即可，忽略音频声道数）；2：双声道（仅支持8k_zh电话场景，双声道应分别对应通话双方）。注意：双声道的电话音频已物理分离说话人，无需再开启说话人分离功能。
        /// </summary>
        [JsonProperty("ChannelNum")]
        public ulong? ChannelNum{ get; set; }

        /// <summary>
        /// 识别结果返回形式。0： 识别结果文本(含分段时间戳)； 1：词级别粒度的[详细识别结果](https://cloud.tencent.com/document/api/1093/37824#SentenceDetail)(不含标点，含语速值)；2：词级别粒度的详细识别结果（包含标点、语速值）；3: 标点符号分段，包含每段时间戳，特别适用于字幕场景（包含词级时间、标点、语速值）。4：【增值付费功能】对识别结果按照语义分段，并展示词级别粒度的详细识别结果，仅支持8k_zh、16k_zh引擎，需购买对应资源包使用（注意：如果账号后付费功能开启并使用此功能，将[自动计费](https://cloud.tencent.com/document/product/1093/35686)）
        /// </summary>
        [JsonProperty("ResTextFormat")]
        public ulong? ResTextFormat{ get; set; }

        /// <summary>
        /// 语音数据来源。0：语音 URL；1：语音数据（post body）。
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 是否开启说话人分离，0：不开启，1：开启(仅支持8k_zh/16k_zh，ChannelNum=1时可用)，默认值为 0。
        /// 注意：8k电话场景建议使用双声道来区分通话双方，设置ChannelNum=2即可，不用开启说话人分离，如果设置了ChannelNum=1，后台会先转码成单声道，说话人分离结果可能产生偏差。
        /// </summary>
        [JsonProperty("SpeakerDiarization")]
        public long? SpeakerDiarization{ get; set; }

        /// <summary>
        /// 说话人分离人数（需配合开启说话人分离使用），取值范围：0-10，0代表自动分离（目前仅支持≤6个人），1-10代表指定说话人数分离。默认值为 0。
        /// 注：此功能结果仅供参考，请根据您的需要谨慎使用。
        /// </summary>
        [JsonProperty("SpeakerNumber")]
        public long? SpeakerNumber{ get; set; }

        /// <summary>
        /// 回调 URL，用户自行搭建的用于接收识别结果的服务URL。如果用户使用轮询方式获取识别结果，则无需提交该参数。回调格式&内容详见：[录音识别回调说明](https://cloud.tencent.com/document/product/1093/52632)
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 语音的URL地址，需要公网环境浏览器可下载。当 SourceType 值为 0 时须填写该字段，为 1 时不需要填写。注意：请确保录音文件时长在5个小时之内，否则可能识别失败。请保证文件的下载速度，否则可能下载失败。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 语音数据base64编码，当SourceType 值为1时必须填写，为0可不写。音频数据要小于5MB。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 数据长度，非必填（此数据长度为数据未进行base64编码时的数据长度）。
        /// </summary>
        [JsonProperty("DataLen")]
        public ulong? DataLen{ get; set; }

        /// <summary>
        /// 是否进行阿拉伯数字智能转换（目前支持中文普通话引擎）。0：不转换，直接输出中文数字，1：根据场景智能转换为阿拉伯数字，3: 打开数学相关数字转换。默认值为 1。
        /// </summary>
        [JsonProperty("ConvertNumMode")]
        public long? ConvertNumMode{ get; set; }

        /// <summary>
        /// 是否过滤脏词（目前支持中文普通话引擎）。0：不过滤脏词；1：过滤脏词；2：将脏词替换为 * 。默认值为 0。
        /// </summary>
        [JsonProperty("FilterDirty")]
        public long? FilterDirty{ get; set; }

        /// <summary>
        /// 热词表id。如不设置该参数，自动生效默认热词表；如设置了该参数，那么将生效对应的热词表。
        /// </summary>
        [JsonProperty("HotwordId")]
        public string HotwordId{ get; set; }

        /// <summary>
        /// 自学习模型 id。如设置了该参数，将生效对应的自学习模型。
        /// </summary>
        [JsonProperty("CustomizationId")]
        public string CustomizationId{ get; set; }

        /// <summary>
        /// 附加参数(该参数无意义，忽略即可)
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 是否过滤标点符号（目前支持中文普通话引擎）。 0：不过滤，1：过滤句末标点，2：过滤所有标点。默认值为 0。
        /// </summary>
        [JsonProperty("FilterPunc")]
        public long? FilterPunc{ get; set; }

        /// <summary>
        /// 是否过滤语气词（目前支持中文普通话引擎）。0：不过滤语气词；1：部分过滤；2：严格过滤 。默认值为 0。
        /// </summary>
        [JsonProperty("FilterModal")]
        public long? FilterModal{ get; set; }

        /// <summary>
        /// 情绪能量值，取值为音量分贝值/10。取值范围：[1,10]。值越高情绪越强烈。0:不开启，1:开启
        /// </summary>
        [JsonProperty("EmotionalEnergy")]
        public long? EmotionalEnergy{ get; set; }

        /// <summary>
        /// 热词增强功能。1:开启后（仅支持8k_zh,16k_zh），将开启同音替换功能，同音字、词在热词中配置。举例：热词配置“蜜制”并开启增强功能后，与“蜜制”同拼音（mizhi）的“秘制”的识别结果会被强制替换成“蜜制”。因此建议客户根据自己的实际情况开启该功能。
        /// </summary>
        [JsonProperty("ReinforceHotword")]
        public long? ReinforceHotword{ get; set; }

        /// <summary>
        /// 单标点最多字数，取值范围：[6，40]。默认为0，不开启该功能。该参数可用于字幕生成场景，控制单行字幕最大字数（设置ResTextFormat为3，解析返回的ResultDetail列表，通过结构中FinalSentence获取单个标点断句结果）。
        /// </summary>
        [JsonProperty("SentenceMaxLength")]
        public long? SentenceMaxLength{ get; set; }

        /// <summary>
        /// 情绪识别能力(目前支持16k_zh) 默认为0，不开启。 1：开启情绪识别但是不会在文本展示“情绪标签”， 2：开启情绪识别并且在文本展示“情绪标签”。（该功能需要设置ResTextFormat 大于0）
        /// 注意：本功能为增值服务，购买对应套餐包后，将参数设置为1或2时方可按对应方式生效，并消耗套餐包对应资源。参数设置为0时无需购买套餐包，也不会消耗对应资源。
        /// </summary>
        [JsonProperty("EmotionRecognition")]
        public long? EmotionRecognition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineModelType", this.EngineModelType);
            this.SetParamSimple(map, prefix + "ChannelNum", this.ChannelNum);
            this.SetParamSimple(map, prefix + "ResTextFormat", this.ResTextFormat);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SpeakerDiarization", this.SpeakerDiarization);
            this.SetParamSimple(map, prefix + "SpeakerNumber", this.SpeakerNumber);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "DataLen", this.DataLen);
            this.SetParamSimple(map, prefix + "ConvertNumMode", this.ConvertNumMode);
            this.SetParamSimple(map, prefix + "FilterDirty", this.FilterDirty);
            this.SetParamSimple(map, prefix + "HotwordId", this.HotwordId);
            this.SetParamSimple(map, prefix + "CustomizationId", this.CustomizationId);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "FilterPunc", this.FilterPunc);
            this.SetParamSimple(map, prefix + "FilterModal", this.FilterModal);
            this.SetParamSimple(map, prefix + "EmotionalEnergy", this.EmotionalEnergy);
            this.SetParamSimple(map, prefix + "ReinforceHotword", this.ReinforceHotword);
            this.SetParamSimple(map, prefix + "SentenceMaxLength", this.SentenceMaxLength);
            this.SetParamSimple(map, prefix + "EmotionRecognition", this.EmotionRecognition);
        }
    }
}

