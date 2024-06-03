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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApiSecEventChangeRequest : AbstractModel
    {
        
        /// <summary>
        /// 变更状态，1:新发现，2，确认中，3，已确认，4，已下线，5，已忽略
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 处理人
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 备注，有长度显示1k
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 批量操作的事件列表
        /// </summary>
        [JsonProperty("EventIdList")]
        public string[] EventIdList{ get; set; }

        /// <summary>
        /// 批量操作的api列表
        /// </summary>
        [JsonProperty("ApiNameList")]
        public ApiSecKey[] ApiNameList{ get; set; }

        /// <summary>
        /// 判断是否删除，包括删除事件和删除资产
        /// </summary>
        [JsonProperty("IsDelete")]
        public bool? IsDelete{ get; set; }

        /// <summary>
        /// 判断是否是更新api的备注，更新api备注的时候，为true
        /// </summary>
        [JsonProperty("UpdateApiRemark")]
        public bool? UpdateApiRemark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "EventIdList.", this.EventIdList);
            this.SetParamArrayObj(map, prefix + "ApiNameList.", this.ApiNameList);
            this.SetParamSimple(map, prefix + "IsDelete", this.IsDelete);
            this.SetParamSimple(map, prefix + "UpdateApiRemark", this.UpdateApiRemark);
        }
    }
}

