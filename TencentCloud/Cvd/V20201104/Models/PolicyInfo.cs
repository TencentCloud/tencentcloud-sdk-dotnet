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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// 策略类型。取值：
        /// 1：文件重定向策略
        /// 2：剪切板重定向策略
        /// 3：外设重定向策略
        /// 4：水印策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// 策略值。取值：
        /// PolicyType对应个子取值范围：
        /// 	①：PolicyType为1-文件重定向策略	
        /// 					1：读写
        /// 					2：只读
        /// 					3：禁止读写
        /// 	②：剪切板重定向策略
        /// 					1：开启云桌面到客户端
        /// 					2：开启客户端到云桌面
        /// 					3：双向开启
        /// 					4：禁用
        /// 	③：外设重定向策略
        /// 					1：允许usb重定向
        /// 					2：允许端口重定向
        /// 					3：允许usb和端口重定向
        /// 					4：禁用
        /// 	④：水印策略
        /// 					4:   当前时间，居中策略
        /// 					10: 当前时间，平铺策略
        /// 					15:  云桌面ID， 居中策略
        ///                                         16:  云桌面ID+当前时间， 居中策略
        ///                                         17:  云桌面ID， 平铺策略
        ///                                         18:  云桌面ID+当前时间， 平铺策略
        /// </summary>
        [JsonProperty("PolicyValue")]
        public long? PolicyValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyValue", this.PolicyValue);
        }
    }
}

