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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosAccessInfo : AbstractModel
    {
        
        /// <summary>
        /// 可访问账号uin
        /// </summary>
        [JsonProperty("AccessUin")]
        public string AccessUin{ get; set; }

        /// <summary>
        /// 可访问账号uid
        /// </summary>
        [JsonProperty("AccessUid")]
        public string AccessUid{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 身份标识 
        /// 1 主账号
        /// 2 子账号
        /// </summary>
        [JsonProperty("Identity")]
        public long? Identity{ get; set; }

        /// <summary>
        /// 所属主账号名称
        /// </summary>
        [JsonProperty("MainNickName")]
        public string MainNickName{ get; set; }

        /// <summary>
        /// 可访问ak列表
        /// </summary>
        [JsonProperty("AkList")]
        public string[] AkList{ get; set; }

        /// <summary>
        /// 可访问权限数
        /// </summary>
        [JsonProperty("CamPolicyCount")]
        public long? CamPolicyCount{ get; set; }

        /// <summary>
        /// 修改时间Unix时间单位毫秒
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessUin", this.AccessUin);
            this.SetParamSimple(map, prefix + "AccessUid", this.AccessUid);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Identity", this.Identity);
            this.SetParamSimple(map, prefix + "MainNickName", this.MainNickName);
            this.SetParamArraySimple(map, prefix + "AkList.", this.AkList);
            this.SetParamSimple(map, prefix + "CamPolicyCount", this.CamPolicyCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

