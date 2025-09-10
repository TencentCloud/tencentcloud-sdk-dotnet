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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MiniAppCreateFlowOption : AbstractModel
    {
        
        /// <summary>
        /// 到期提醒日（linux时间戳） 精确到天
        /// </summary>
        [JsonProperty("RemindedOn")]
        public long? RemindedOn{ get; set; }

        /// <summary>
        /// 是否需要发起前进行审批
        /// </summary>
        [JsonProperty("NeedCreateReview")]
        public bool? NeedCreateReview{ get; set; }

        /// <summary>
        /// 在短信通知、填写、签署流程中，若标题、按钮、合同详情等地方存在“合同”字样时，可根据此配置指定文案，可选文案如下：  <ul><li> <b>0</b> :合同（默认值）</li> <li> <b>1</b> :文件</li> <li> <b>2</b> :协议</li><li> <b>3</b> :文书</li></ul>效果如下:![FlowDisplayType](https://qcloudimg.tencent-cloud.cn/raw/e4a2c4d638717cc901d3dbd5137c9bbc.png)
        /// </summary>
        [JsonProperty("FlowDisplayType")]
        public long? FlowDisplayType{ get; set; }

        /// <summary>
        /// 小程序集成发起，是否禁止发起时修改合同内容
        /// <ul>
        /// <li>false：默认值，不禁止发起时修改合同内容</li>
        /// <li>true：禁止发起时修改合同内容</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ForbidEditFlow")]
        public bool? ForbidEditFlow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RemindedOn", this.RemindedOn);
            this.SetParamSimple(map, prefix + "NeedCreateReview", this.NeedCreateReview);
            this.SetParamSimple(map, prefix + "FlowDisplayType", this.FlowDisplayType);
            this.SetParamSimple(map, prefix + "ForbidEditFlow", this.ForbidEditFlow);
        }
    }
}

