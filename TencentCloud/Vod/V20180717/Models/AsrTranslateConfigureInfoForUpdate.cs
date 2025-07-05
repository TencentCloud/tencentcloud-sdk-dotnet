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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsrTranslateConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 语音翻译识别任务开关，可选值：
        /// <li>ON：开启；</li>
        /// <li>OFF：关闭。</li><font color=red>注意：</font>语音翻译识别任务本身会返回 ASR 全文识别结果，为避免重复收费，因此禁止同时开启语音翻译识别和 ASR 全文识别功能项。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 媒体源语言，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>ja：日文；</li>
        /// <li>ko：韩文；</li>
        /// <li>vi：越南语；</li>
        /// <li>ms：马来语；</li>
        /// <li>th：泰语；</li>
        /// <li>pt：葡萄牙语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ar：阿拉伯语；</li>
        /// <li>es：西班牙语；</li>
        /// <li>hi：印地语；</li>
        /// <li>fr：法语。</li>
        /// </summary>
        [JsonProperty("SrcLanguage")]
        public string SrcLanguage{ get; set; }

        /// <summary>
        /// 翻译目标语言。
        /// 若此参数填写空字符串，则表示只进行语音全文识别，不进行翻译（计费项与 AsrFullTextConfigure 语音全文识别一致）；
        /// 否则，此参数的取值范围分为如下几种情况：
        /// 当 SrcLanguage 为 zh（中文）时，取值范围：
        /// <li>en：英文；</li>
        /// <li>ja：日文；</li>
        /// <li>ko：韩文；</li>
        /// <li>fr：法语；</li>
        /// <li>es：西班牙语；</li>
        /// <li>it：意大利语；</li>
        /// <li>de：德语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ru：俄语；</li>
        /// <li>pt：葡萄牙语；</li>
        /// <li>vi：越南语；</li>
        /// <li>id：印尼语；</li>
        /// <li>th：泰语；</li>
        /// <li>ms：马来语。</li>
        /// 当 SrcLanguage 为 en（英文）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>ja：日文；</li>
        /// <li>ko：韩文；</li>
        /// <li>fr：法语；</li>
        /// <li>es：西班牙语；</li>
        /// <li>it：意大利语；</li>
        /// <li>de：德语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ru：俄语；</li>
        /// <li>pt：葡萄牙语；</li>
        /// <li>vi：越南语；</li>
        /// <li>id：印尼语；</li>
        /// <li>th：泰语；</li>
        /// <li>ms：马来语；</li>
        /// <li>ar：阿拉伯语；</li>
        /// <li>hi：印地语。</li>
        /// 当 SrcLanguage 为 ja（日文）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>ko：韩文。</li>
        /// 当 SrcLanguage 为 ko（韩文）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>ja：日文。</li>
        /// 当 SrcLanguage 为 vi（越南语）或 ms（马来语）或 th（泰语）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文。</li>
        /// 当 SrcLanguage 为 pt（葡萄牙语）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>fr：法语；</li>
        /// <li>es：西班牙语；</li>
        /// <li>it：意大利语；</li>
        /// <li>de：德语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ru：俄语。</li>
        /// 当 SrcLanguage 为 tr（土耳其语）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>fr：法语；</li>
        /// <li>es：西班牙语；</li>
        /// <li>it：意大利语；</li>
        /// <li>de：德语；</li>
        /// <li>ru：俄语；</li>
        /// <li>pt：葡萄牙语。</li>
        /// 当 SrcLanguage 为 es（西班牙语）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>fr：法语；</li>
        /// <li>it：意大利语；</li>
        /// <li>de：德语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ru：俄语；</li>
        /// <li>pt：葡萄牙语。</li>
        /// 当 SrcLanguage 为 ar（阿拉伯语）或 hi（印地语）时，取值范围：
        /// <li>en：英文。</li>
        /// 当 SrcLanguage 为 fr（法语）时，取值范围：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>es：西班牙语；</li>
        /// <li>it：意大利语；</li>
        /// <li>de：德语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ru：俄语；</li>
        /// <li>pt：葡萄牙语。</li>
        /// </summary>
        [JsonProperty("DstLanguage")]
        public string DstLanguage{ get; set; }

        /// <summary>
        /// 字幕格式列表操作信息。
        /// </summary>
        [JsonProperty("SubtitleFormatsOperation")]
        public SubtitleFormatsOperation SubtitleFormatsOperation{ get; set; }

        /// <summary>
        /// 指定字幕名称，长度限制：64 个字符。该值将用于播放器展示。
        /// </summary>
        [JsonProperty("SubtitleName")]
        public string SubtitleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "SrcLanguage", this.SrcLanguage);
            this.SetParamSimple(map, prefix + "DstLanguage", this.DstLanguage);
            this.SetParamObj(map, prefix + "SubtitleFormatsOperation.", this.SubtitleFormatsOperation);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
        }
    }
}

