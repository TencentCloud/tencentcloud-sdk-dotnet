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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 客户的AppId
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 是否开通过白板（试用或正式）
        /// 
        /// 0: 从未开通过白板服务
        /// 1: 已经开通过白板服务
        /// </summary>
        [JsonProperty("IsTiwUser")]
        public long? IsTiwUser{ get; set; }

        /// <summary>
        /// 是否开通过互动课堂（试用或正式）
        /// </summary>
        [JsonProperty("IsSaaSUser")]
        public long? IsSaaSUser{ get; set; }

        /// <summary>
        /// 是否使用白板的课后录制
        /// </summary>
        [JsonProperty("IsTiwOfflineRecordUser")]
        public long? IsTiwOfflineRecordUser{ get; set; }

        /// <summary>
        /// 用户是否实名认证
        /// </summary>
        [JsonProperty("IsAuthenticated")]
        public long? IsAuthenticated{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "IsTiwUser", this.IsTiwUser);
            this.SetParamSimple(map, prefix + "IsSaaSUser", this.IsSaaSUser);
            this.SetParamSimple(map, prefix + "IsTiwOfflineRecordUser", this.IsTiwOfflineRecordUser);
            this.SetParamSimple(map, prefix + "IsAuthenticated", this.IsAuthenticated);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

