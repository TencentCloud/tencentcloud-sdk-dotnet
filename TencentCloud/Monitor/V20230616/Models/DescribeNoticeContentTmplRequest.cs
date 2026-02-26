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

    public class DescribeNoticeContentTmplRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页数
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 指定模板ID查询，查询参数都为空则默认查询账号下所有模板
        /// </summary>
        [JsonProperty("TmplIDs")]
        public string[] TmplIDs{ get; set; }

        /// <summary>
        /// 指定模板名称查询，查询参数都为空则默认查询账号下所有模板
        /// </summary>
        [JsonProperty("TmplName")]
        public string TmplName{ get; set; }

        /// <summary>
        /// 指定通知模板ID查询，查询参数都为空则默认查询账号下所有模板
        /// </summary>
        [JsonProperty("NoticeID")]
        public string NoticeID{ get; set; }

        /// <summary>
        /// 模板语言 en/zh 缺省不过滤
        /// </summary>
        [JsonProperty("TmplLanguage")]
        public string TmplLanguage{ get; set; }

        /// <summary>
        /// 监控类型
        /// </summary>
        [JsonProperty("MonitorType")]
        public string MonitorType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "TmplIDs.", this.TmplIDs);
            this.SetParamSimple(map, prefix + "TmplName", this.TmplName);
            this.SetParamSimple(map, prefix + "NoticeID", this.NoticeID);
            this.SetParamSimple(map, prefix + "TmplLanguage", this.TmplLanguage);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
        }
    }
}

