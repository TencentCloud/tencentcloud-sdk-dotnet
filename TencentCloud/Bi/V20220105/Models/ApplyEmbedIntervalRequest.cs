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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyEmbedIntervalRequest : AbstractModel
    {
        
        /// <summary>
        /// 分享项目id，必选
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 分享页面id，嵌出看板时此为空值0，ChatBI嵌出时不传
        /// </summary>
        [JsonProperty("PageId")]
        public ulong? PageId{ get; set; }

        /// <summary>
        /// 需要申请延期的Token
        /// </summary>
        [JsonProperty("BIToken")]
        public string BIToken{ get; set; }

        /// <summary>
        /// 备用字段
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// embed：页面/看板嵌出
        /// chatBIEmbed：ChatBI嵌出
        /// </summary>
        [JsonProperty("Intention")]
        public string Intention{ get; set; }

        /// <summary>
        /// panel, 看板；page，页面
        /// project，ChatBI嵌出时
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "BIToken", this.BIToken);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "Intention", this.Intention);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
        }
    }
}

