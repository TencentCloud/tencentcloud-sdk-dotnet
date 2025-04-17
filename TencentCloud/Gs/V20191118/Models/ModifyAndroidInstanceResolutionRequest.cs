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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAndroidInstanceResolutionRequest : AbstractModel
    {
        
        /// <summary>
        /// 安卓实例 ID
        /// </summary>
        [JsonProperty("AndroidInstanceId")]
        public string AndroidInstanceId{ get; set; }

        /// <summary>
        /// 分辨率宽度。建议按照以下数值设置，避免出现性能不足问题：
        /// 实例类型为单开（A1）：建议设置为 1080
        /// 实例类型为双开（A2） 及以上：建议设置为 720
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 分辨率高度。建议按照以下数值设置，避免出现性能不足问题：
        /// 实例类型为单开（A1）：建议设置为 1920
        /// 实例类型为双开（A2） 及以上：建议设置为 1280
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 每英寸像素点。如果不填，系统将会计算一个合理的数值。修改 DPI 可能会导致 App 异常退出，请谨慎使用！
        /// 分辨率为 720x1280：建议配置为 320
        /// 分辨率为  1080x1920：建议配置为 480
        /// </summary>
        [JsonProperty("DPI")]
        public ulong? DPI{ get; set; }

        /// <summary>
        /// 帧率。ResolutionType 为 PHYSICAL 时才会修改帧率。另外建议按照以下数值设置，避免出现性能不足问题： 实例类型为单开（A1）：建议设置为 60 实例类型为双开（A2） 及以上：建议设置为 30
        /// </summary>
        [JsonProperty("FPS")]
        public ulong? FPS{ get; set; }

        /// <summary>
        /// 修改分辨率类型。修改物理分辨率，需要重启才能生效。
        /// OVERRIDE：默认值，修改覆盖（显示）分辨率
        /// PHYSICAL：修改物理分辨率
        /// </summary>
        [JsonProperty("ResolutionType")]
        public string ResolutionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidInstanceId", this.AndroidInstanceId);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "DPI", this.DPI);
            this.SetParamSimple(map, prefix + "FPS", this.FPS);
            this.SetParamSimple(map, prefix + "ResolutionType", this.ResolutionType);
        }
    }
}

