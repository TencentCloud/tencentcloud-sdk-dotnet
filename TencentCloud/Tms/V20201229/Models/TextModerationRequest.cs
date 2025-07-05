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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// 该字段表示待检测对象的文本内容，文本需要按utf-8格式编码，长度不能超过10000个字符（按unicode编码计算），并进行 Base64加密
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 该字段表示使用的策略的具体编号，该字段需要先在[内容安全控制台](https://console.cloud.tencent.com/cms/clouds/manage)中配置，控制台访问地址：。
        /// 备注：不同Biztype关联不同的业务场景与识别能力策略，调用前请确认正确的Biztype。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 该字段表示您为待检测对象分配的数据ID，传入后可方便您对文件进行标识和管理。<br>取值：由英文字母（大小写均可）、数字及四个特殊符号（_，-，@，#）组成，**长度不超过64个字符**
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 该字段表示待检测对象对应的用户相关信息，传入后可便于甄别相应违规风险用户
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }

        /// <summary>
        /// 该字段表示待检测对象对应的设备相关信息，传入后可便于甄别相应违规风险设备
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }

        /// <summary>
        /// 表示Content的原始语种，枚举值包括 "en" 和 "zh"。其中，"en" 表示英文，"zh" 表示中文。非中文场景的处理耗时较高，具体情况取决于送审文本长度，非中文场景需[反馈工单](https://console.cloud.tencent.com/workorder/category?level1_id=141&level2_id=1287&source=14&data_title=%E6%96%87%E6%9C%AC%E5%86%85%E5%AE%B9%E5%AE%89%E5%85%A8&step=1)确认。
        /// </summary>
        [JsonProperty("SourceLanguage")]
        public string SourceLanguage{ get; set; }

        /// <summary>
        /// 审核的业务类型，枚举值包括"TEXT"和"TEXT_AIGC"。其中"TEXT"表示传统文本审核，"TEXT_AIGC”表示AI生成检测（生成检测能力具体能力了解可[参见文档](https://cloud.tencent.com/document/product/1124/118694)）。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamObj(map, prefix + "Device.", this.Device);
            this.SetParamSimple(map, prefix + "SourceLanguage", this.SourceLanguage);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

