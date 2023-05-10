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

namespace TencentCloud.Tts.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextToVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 合成语音的源文本，按UTF-8编码统一计算。
        /// 中文最大支持150个汉字（全角标点符号算一个汉字）；英文最大支持500个字母（半角标点符号算一个字母）。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 一次请求对应一个SessionId，会原样返回，建议传入类似于uuid的字符串防止重复。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 音量大小，范围：[0，10]，分别对应11个等级的音量，默认为0，代表正常音量。没有静音选项。
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// 语速，范围：[-2，6]，分别对应不同语速：<li>-2代表0.6倍</li><li>-1代表0.8倍</li><li>0代表1.0倍（默认）</li><li>1代表1.2倍</li><li>2代表1.5倍</li><li>6代表2.5倍</li>如果需要更细化的语速，可以保留小数点后一位，例如0.5 1.1 1.8等。<br>
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// 项目id，用户自定义，默认为0。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 模型类型，1-默认模型。
        /// </summary>
        [JsonProperty("ModelType")]
        public long? ModelType{ get; set; }

        /// <summary>
        /// 标准音色<li>10510000-智逍遥，阅读男声</li><li>1001-智瑜，情感女声</li><li>1002-智聆，通用女声</li><li>1003-智美，客服女声</li><li>1004-智云，通用男声</li><li>1005-智莉，通用女声</li><li>1007-智娜，客服女声</li><li>1008-智琪，客服女声</li><li>1009-智芸，知性女声</li><li>1010-智华，通用男声</li><li>1017-智蓉，情感女声</li><li>1018-智靖，情感男声</li><li>1050-WeJack，英文男声</li><li>1051-WeRose，英文女声</li>精品音色<br>精品音色拟真度更高，价格不同于标准音色，查看[购买指南](https://cloud.tencent.com/document/product/1073/34112)<br><li>100510000-智逍遥，阅读男声</li><li>101001-智瑜，情感女声</li><li>101002-智聆，通用女声</li><li>101003-智美，客服女声</li><li>101004-智云，通用男声</li><li>101005-智莉，通用女声</li><li>101006-智言，助手女声</li><li>101007-智娜，客服女声</li><li>101008-智琪，客服女声</li><li>101009-智芸，知性女声</li><li>101010-智华，通用男声</li><li>101011-智燕，新闻女声</li><li>101012-智丹，新闻女声</li><li>101013-智辉，新闻男声</li><li>101014-智宁，新闻男声</li><li>101015-智萌，男童声</li><li>101016-智甜，女童声</li><li>101017-智蓉，情感女声</li><li>101018-智靖，情感男声</li><li>101019-智彤，粤语女声</li><li>101020-智刚，新闻男声</li><li>101021-智瑞，新闻男声</li><li>101022-智虹，新闻女声</li><li>101023-智萱，聊天女声</li><li>101024-智皓，聊天男声</li><li>101025-智薇，聊天女声</li><li>101026-智希，通用女声</li><li>101027-智梅，通用女声</li><li>101028-智洁，通用女声</li><li>101029-智凯，通用男声</li><li>101030-智柯，通用男声</li><li>101031-智奎，通用男声</li><li>101032-智芳，通用女声</li><li>101033-智蓓，客服女声</li><li>101034-智莲，通用女声</li><li>101035-智依，通用女声</li><li>101040-智川，四川女声</li><li>101050-WeJack，英文男声</li><li>101051-WeRose，英文女声</li><li>101052-智味，通用男声</li>
        /// <li>101053-智方，通用男声</li>
        /// <li>101054-智友，通用男声</li>
        /// <li>101055-智付，通用女声</li>
        /// <li>101056-智林，东北男声</li>
        /// <li>301000-爱小广，多情感通用男声</li>
        /// <li>301001-爱小栋，多情感通用男声</li>
        /// <li>301002-爱小海，多情感通用男声</li>
        /// <li>301003-爱小霞，多情感通用女声</li>
        /// <li>301004-爱小玲，多情感通用女声</li>
        /// <li>301005-爱小章，多情感通用男声</li>
        /// <li>301006-爱小峰，多情感通用男声</li>
        /// <li>301007-爱小亮，多情感通用男声</li>
        /// <li>301008-爱小博，多情感通用男声</li>
        /// <li>301009-爱小芸，多情感通用女声</li>
        /// <li>301010-爱小秋，多情感通用女声</li>
        /// <li>301011-爱小芳，多情感通用女声</li>
        /// <li>301012-爱小琴，多情感通用女声</li>
        /// <li>301013-爱小康，多情感通用男声</li>
        /// <li>301014-爱小辉，多情感通用男声</li>
        /// <li>301015-爱小璐，多情感通用女声</li>
        /// <li>301016-爱小阳，多情感通用男声</li>
        /// <li>301017-爱小泉，多情感通用男声</li>
        /// <li>301018-爱小昆，多情感通用男声</li>
        /// <li>301019-爱小诚，多情感通用男声</li>
        /// <li>301020-爱小岚，多情感通用女声</li>
        /// <li>301021-爱小茹，多情感通用女声</li>
        /// <li>301022-爱小蓉，多情感通用女声</li>
        /// <li>301023-爱小燕，多情感通用女声</li>
        /// <li>301024-爱小莲，多情感通用女声</li>
        /// <li>301025-爱小武，多情感通用男声</li>
        /// <li>301026-爱小雪，多情感通用女声</li>
        /// <li>301027-爱小媛，多情感通用女声</li>
        /// <li>301028-爱小娴，多情感通用女声</li>
        /// <li>301029-爱小涛，多情感通用男声</li>
        /// <li>401000-智妍，活力女声</li>
        /// <li>401001-智萱，温暖女声</li>
        /// <li>401002-智飞，活力男声</li>
        /// <li>401003-智悦，活力女声</li>
        /// <li>401004-智海，成熟男声</li>
        /// <li>401005-智凡，新闻男声</li>
        /// <li>401006-智航，导航女声</li>
        /// <li>401007-智婷，广告女声</li>
        /// <li>401008-智霞，通用女声</li>
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }

        /// <summary>
        /// 主语言类型：<li>1-中文（默认）</li><li>2-英文</li>
        /// </summary>
        [JsonProperty("PrimaryLanguage")]
        public long? PrimaryLanguage{ get; set; }

        /// <summary>
        /// 音频采样率：<li>16000：16k（默认）</li><li>8000：8k</li>
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// 返回音频格式，可取值：wav（默认），mp3，pcm
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 是否开启时间戳功能，默认为false。
        /// </summary>
        [JsonProperty("EnableSubtitle")]
        public bool? EnableSubtitle{ get; set; }

        /// <summary>
        /// 断句敏感阈值，默认值为：0，取值范围：[0,1,2]。该值越大越不容易断句，模型会更倾向于仅按照标点符号断句。此参数建议不要随意调整，可能会影响合成效果。
        /// </summary>
        [JsonProperty("SegmentRate")]
        public ulong? SegmentRate{ get; set; }

        /// <summary>
        /// 控制合成音频的情感，仅支持多情感音色使用。取值: neutral(中性)、sad(悲伤)、happy(高兴)、angry(生气)、fear(恐惧)、news(新闻)、story(故事)、radio(广播)、poetry(诗歌)、call(客服)
        /// </summary>
        [JsonProperty("EmotionCategory")]
        public string EmotionCategory{ get; set; }

        /// <summary>
        /// 控制合成音频情感程度，取值范围为[50,200],默认为100；只有EmotionCategory不为空时生效；
        /// </summary>
        [JsonProperty("EmotionIntensity")]
        public long? EmotionIntensity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "PrimaryLanguage", this.PrimaryLanguage);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "EnableSubtitle", this.EnableSubtitle);
            this.SetParamSimple(map, prefix + "SegmentRate", this.SegmentRate);
            this.SetParamSimple(map, prefix + "EmotionCategory", this.EmotionCategory);
            this.SetParamSimple(map, prefix + "EmotionIntensity", this.EmotionIntensity);
        }
    }
}

