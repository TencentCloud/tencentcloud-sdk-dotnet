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

namespace TencentCloud.Mmps.V20200710.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFlySecMiniAppScanTaskParamResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回值, 0:成功, 其他值请查看“返回值”定义
        /// </summary>
        [JsonProperty("Ret")]
        public long? Ret{ get; set; }

        /// <summary>
        /// 小程序AppID
        /// </summary>
        [JsonProperty("MiniAppID")]
        public string MiniAppID{ get; set; }

        /// <summary>
        /// 诊断模式 1:基础诊断，2:深度诊断
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 小程序测试账号(自有账号体系需提供,其他情况不需要)
        /// </summary>
        [JsonProperty("MiniAppTestAccount")]
        public string MiniAppTestAccount{ get; set; }

        /// <summary>
        /// 小程序测试密码(自有账号体系需提供,其他情况不需要)
        /// </summary>
        [JsonProperty("MiniAppTestPwd")]
        public string MiniAppTestPwd{ get; set; }

        /// <summary>
        /// 诊断扫描版本 0:正式版 1:体验版
        /// </summary>
        [JsonProperty("ScanVersion")]
        public long? ScanVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ret", this.Ret);
            this.SetParamSimple(map, prefix + "MiniAppID", this.MiniAppID);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "MiniAppTestAccount", this.MiniAppTestAccount);
            this.SetParamSimple(map, prefix + "MiniAppTestPwd", this.MiniAppTestPwd);
            this.SetParamSimple(map, prefix + "ScanVersion", this.ScanVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

