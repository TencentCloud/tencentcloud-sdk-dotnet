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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNoticeContentTmplRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("TmplName")]
        public string TmplName{ get; set; }

        /// <summary>
        /// 监控类型
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonProperty("TmplContents")]
        public NoticeContentTmplItem TmplContents{ get; set; }

        /// <summary>
        /// 模板语言 en/zh
        /// </summary>
        [JsonProperty("TmplLanguage")]
        public string TmplLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TmplName", this.TmplName);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamObj(map, prefix + "TmplContents.", this.TmplContents);
            this.SetParamSimple(map, prefix + "TmplLanguage", this.TmplLanguage);
        }
    }
}

