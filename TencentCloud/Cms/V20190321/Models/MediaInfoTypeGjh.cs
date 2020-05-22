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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaInfoTypeGjh : AbstractModel
    {
        
        /// <summary>
        /// 动作
        /// </summary>
        [JsonProperty("StrAction")]
        public string StrAction{ get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("StrContent")]
        public string StrContent{ get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("StrFileID")]
        public string StrFileID{ get; set; }

        /// <summary>
        /// md5，填了可提高识别率
        /// </summary>
        [JsonProperty("StrMD5")]
        public string StrMD5{ get; set; }

        /// <summary>
        /// Sha
        /// </summary>
        [JsonProperty("StrSha")]
        public string StrSha{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("StrTitle")]
        public string StrTitle{ get; set; }

        /// <summary>
        /// url
        /// </summary>
        [JsonProperty("StrUrl")]
        public string StrUrl{ get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [JsonProperty("UiSize")]
        public long? UiSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrAction", this.StrAction);
            this.SetParamSimple(map, prefix + "StrContent", this.StrContent);
            this.SetParamSimple(map, prefix + "StrFileID", this.StrFileID);
            this.SetParamSimple(map, prefix + "StrMD5", this.StrMD5);
            this.SetParamSimple(map, prefix + "StrSha", this.StrSha);
            this.SetParamSimple(map, prefix + "StrTitle", this.StrTitle);
            this.SetParamSimple(map, prefix + "StrUrl", this.StrUrl);
            this.SetParamSimple(map, prefix + "UiSize", this.UiSize);
        }
    }
}

