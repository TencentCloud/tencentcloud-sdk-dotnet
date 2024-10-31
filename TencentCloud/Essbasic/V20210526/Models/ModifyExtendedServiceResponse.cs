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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyExtendedServiceResponse : AbstractModel
    {
        
        /// <summary>
        /// 操作跳转链接
        /// <ul><li><strong>链接有效期：</strong> 跳转链接的有效期为24小时。</li>
        /// <li><strong>没有返回链接的情形：</strong> 如果在操作时没有返回跳转链接，说明此次操作无需进行跳转，服务将会直接被开通或关闭。</li>
        /// <li><strong>返回链接的情形：</strong> 当操作类型为<b>OPEN（开通服务）</b>，并且扩展服务类型为<b>AUTO_SIGN（ 企业自动签署）</b>、<b>DOWNLOAD_FLOW（授权渠道下载合同）</b>时，系统将返回一个操作链接。收到操作链接后，贵方需主动联系超级管理员（超管）或法人。<font color="red"><b>由超管或法人点击链接</b></font>，以完成服务的开通操作。</li>
        /// </ul>
        /// 
        /// </summary>
        [JsonProperty("OperateUrl")]
        public string OperateUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "OperateUrl", this.OperateUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

