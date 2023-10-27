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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAlertCenterIsolateRequest : AbstractModel
    {
        
        /// <summary>
        /// 处置对象,资产列表
        /// </summary>
        [JsonProperty("HandleAssetList")]
        public string[] HandleAssetList{ get; set; }

        /// <summary>
        /// 处置时间
        /// 1  1天
        /// 7   7天
        /// -2 永久
        /// </summary>
        [JsonProperty("HandleTime")]
        public long? HandleTime{ get; set; }

        /// <summary>
        /// 当前日志方向： 0 出向 1 入向
        /// </summary>
        [JsonProperty("AlertDirection")]
        public long? AlertDirection{ get; set; }

        /// <summary>
        /// 隔离类型 
        /// 1 互联网入站
        /// 2 互联网出站
        /// 4 内网访问
        /// </summary>
        [JsonProperty("IsolateType")]
        public long?[] IsolateType{ get; set; }

        /// <summary>
        /// 运维模式 1 IP白名单 2 身份认证
        /// </summary>
        [JsonProperty("OmMode")]
        public long? OmMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HandleAssetList.", this.HandleAssetList);
            this.SetParamSimple(map, prefix + "HandleTime", this.HandleTime);
            this.SetParamSimple(map, prefix + "AlertDirection", this.AlertDirection);
            this.SetParamArraySimple(map, prefix + "IsolateType.", this.IsolateType);
            this.SetParamSimple(map, prefix + "OmMode", this.OmMode);
        }
    }
}

