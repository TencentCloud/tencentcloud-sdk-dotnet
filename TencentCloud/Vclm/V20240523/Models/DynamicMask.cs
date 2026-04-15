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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DynamicMask : AbstractModel
    {
        
        /// <summary>
        /// <p>动态笔刷涂抹区域（用户通过运动笔刷涂抹的 mask 图片）</p><p>支持传入图片Base64编码或图片URL（确保可访问，格式要求同 Image 字段）<br>图片格式支持.jpg / .jpeg / .png<br>图片长宽比必须与输入图片相同（即Image字段），否则任务失败<br>StaticMask 和 DynamicMasks.Mask 这两张图片的分辨率必须一致，否则任务失败</p>
        /// </summary>
        [JsonProperty("Mask")]
        public string Mask{ get; set; }

        /// <summary>
        /// <p>运动轨迹坐标序列</p><p>生成5s的视频，轨迹长度不超过77，即坐标个数取值范围：[2, 77]<br>轨迹坐标系，以图片左下角为坐标原点<br>注1：坐标点个数越多轨迹刻画越准确，如只有2个轨迹点则为这两点连接的直线<br>注2：轨迹方向以传入顺序为指向，以最先传入的坐标为轨迹起点，依次连接后续坐标形成运动轨迹</p>
        /// </summary>
        [JsonProperty("Trajectories")]
        public Trajectory[] Trajectories{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mask", this.Mask);
            this.SetParamArrayObj(map, prefix + "Trajectories.", this.Trajectories);
        }
    }
}

