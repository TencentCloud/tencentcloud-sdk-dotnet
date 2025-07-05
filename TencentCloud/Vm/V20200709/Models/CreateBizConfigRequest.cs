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

namespace TencentCloud.Vm.V20200709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBizConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务ID，仅限英文字母、数字和下划线（_）组成，长度不超过8位
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 审核分类信息
        /// </summary>
        [JsonProperty("MediaModeration")]
        public MediaModerationConfig MediaModeration{ get; set; }

        /// <summary>
        /// 业务名称，用于标识业务场景，长度不超过32位
        /// </summary>
        [JsonProperty("BizName")]
        public string BizName{ get; set; }

        /// <summary>
        /// 审核内容，可选：Polity (政治); Porn (色情); Illegal(违法);Abuse (谩骂); Terror (暴恐); Ad (广告); Custom (自定义);
        /// </summary>
        [JsonProperty("ModerationCategories")]
        public string[] ModerationCategories{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamObj(map, prefix + "MediaModeration.", this.MediaModeration);
            this.SetParamSimple(map, prefix + "BizName", this.BizName);
            this.SetParamArraySimple(map, prefix + "ModerationCategories.", this.ModerationCategories);
        }
    }
}

