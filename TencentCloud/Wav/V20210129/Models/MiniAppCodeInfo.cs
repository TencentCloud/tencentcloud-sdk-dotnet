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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MiniAppCodeInfo : AbstractModel
    {
        
        /// <summary>
        /// 主键id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [JsonProperty("MiniAppName")]
        public string MiniAppName{ get; set; }

        /// <summary>
        /// 小程序logo
        /// </summary>
        [JsonProperty("MiniAppLogo")]
        public string MiniAppLogo{ get; set; }

        /// <summary>
        /// 小程序管理端地址
        /// </summary>
        [JsonProperty("MiniAdminUrl")]
        public string MiniAdminUrl{ get; set; }

        /// <summary>
        /// 状态：0正常，1删除
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 创建时间戳，单位为秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间戳，单位为秒
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MiniAppName", this.MiniAppName);
            this.SetParamSimple(map, prefix + "MiniAppLogo", this.MiniAppLogo);
            this.SetParamSimple(map, prefix + "MiniAdminUrl", this.MiniAdminUrl);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

