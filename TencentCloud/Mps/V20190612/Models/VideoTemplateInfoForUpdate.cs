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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 视频流的编码格式，可选值：
        /// <li>h264：H.264 编码</li>
        /// <li>h265：H.265 编码</li>
        /// <li>h266：H.266 编码</li>
        /// <li>av1：AOMedia Video 1 编码</li>
        /// <li>vp8：VP8 编码</li>
        /// <li>vp9：VP9 编码</li>
        /// <li>mpeg2：MPEG2 编码</li>
        /// <li>dnxhd：DNxHD 编码</li>
        /// <li>mv-hevc：MV-HEVC 编码</li>
        /// 
        /// 注意：av1 编码容器目前只支持 mp4 ，webm，mkv。
        /// 注意：H.266 编码容器目前只支持 mp4 ，hls，ts，mov。
        /// 注意：VP8、VP9编码容器目前只支持webm，mkv。
        /// 注意：MPEG2、dnxhd 编码容器目前只支持mxf。
        /// 注意：MV-HEVC编码容器目前只支持mp4，hls，mov。其中hls格式只支持mp4分片格式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 视频帧率，取值范围：
        /// 当FpsDenominator的值为空时，范围：[0, 120]，单位：Hz；
        /// 当FpsDenominator的值不为空时，Fps/FpsDenominator的范围：[0,120]
        /// 当取值为 0，表示帧率和原始视频保持一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 视频流的码率，取值范围：0 和 [128, 100000]，单位：kbps。
        /// 当取值为 0，表示视频码率和原始视频保持一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// 分辨率自适应，可选值：
        /// <li>open：开启，此时，Width 代表视频的长边，Height 表示视频的短边；</li>
        /// <li>close：关闭，此时，Width 代表视频的宽度，Height 表示视频的高度。</li>
        /// 注意：自适应模式时，Width不能小于Height。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// 视频流宽度（或长边）的最大值，取值范围：0 和 [128, 4096]，单位：px。
        /// <li>当 Width、Height 均为 0，则分辨率同源；</li>
        /// <li>当 Width 为 0，Height 非 0，则 Width 按比例缩放；</li>
        /// <li>当 Width 非 0，Height 为 0，则 Height 按比例缩放；</li>
        /// <li>当 Width、Height 均非 0，则分辨率按用户指定。</li>
        /// 注意：Codec为MV-HEVC时可以支持到7680
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 视频流高度（或短边）的最大值，取值范围：0 和 [128, 4096]，单位：px。
        /// 注意：Codec为MV-HEVC时可以支持到7680
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 关键帧 I 帧之间的间隔，允许按帧或秒自定义GOP长度，取值范围：0 和 [1, 100000]。
        /// 当填 0 时，系统将自动设置 gop 长度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// Gop数值单位，可选值： 
        /// frame：表示帧 
        /// second：表示秒
        /// 默认值：frame
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GopUnit")]
        public string GopUnit{ get; set; }

        /// <summary>
        /// 填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。可选填充方式：
        ///  <li> stretch：拉伸，对每一帧进行拉伸，填满整个画面，可能导致转码后的视频被“压扁“或者“拉长“；</li>
        /// <li>black：留黑，保持视频宽高比不变，边缘剩余部分使用黑色填充。</li>
        /// <li>white：留白，保持视频宽高比不变，边缘剩余部分使用白色填充。</li>
        /// <li>gauss：高斯模糊，保持视频宽高比不变，边缘剩余部分使用高斯模糊填充。</li>
        /// <li>smarttailor：智能剪裁：智能选取视频画面，来保证画面比例裁剪。</li>
        /// 默认值：black 。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// 视频的恒定码率控制因子，取值范围为[0, 51]，不填表示“自动”。如果没有特殊需求，建议不指定该参数。
        /// 当Mode参数设置为VBR时，如果同时配置了Vcrf值，MPS将在VBR模式下处理视频，同时考虑Vcrf和Bitrate参数的设置，以平衡视频质量、码率、转码效率和文件大小。
        /// 当Mode参数设置为CRF，Bitrate设置将失效，编码将根据Vcrf值进行。
        /// 当Mode参数选择ABR或CBR时，无需配置Vcrf值。
        /// 注意：需要修改为自动时，填100
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// 内容自适应编码。可选值：
        /// <li>0：不开启</li>
        /// <li>1：开启</li>
        /// 默认值: 0.   当开启该参数时，将会自适应生成多个不同分辨率，不同码率的码流， 其中VideoTemplate的宽和高为多个码流中的最大分辨率，VideoTemplate中的码率为多个码流中的最高码率， VideoTemplate中的vcrf为多个码流中的最高质量。 当不设置分辨率、码率和vcrf时， ContentAdaptStream 参数生成的最高分辨率为视频源的分辨率，视频质量为接近vmaf95分。 若要开启该参数或了解计费细节, 请联系您的腾讯云商务。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentAdaptStream")]
        public ulong? ContentAdaptStream{ get; set; }

        /// <summary>
        /// 分片平均时长，取值范围：（0-10]，单位：秒
        /// 默认值：10
        /// 注意：只在封装格式HLS时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HlsTime")]
        public ulong? HlsTime{ get; set; }

        /// <summary>
        /// hls 分片类型，可选值：
        /// <li>0：HLS+TS 切片</li>
        /// <li>2：HLS+TS byte range</li>
        /// <li>7：HLS+MP4 切片</li>
        /// <li>5：HLS+MP4 byte range</li>
        /// 默认值：0
        /// 注意：该字段用于普通/极速高清转码设置，对自适应码流不生效，如需给自适应码流配置分片类型，可以使用外层字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SegmentType")]
        public long? SegmentType{ get; set; }

        /// <summary>
        /// 帧率分母部分
        /// 注意：值必须大于0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FpsDenominator")]
        public long? FpsDenominator{ get; set; }

        /// <summary>
        /// 3D视频拼接方式，仅mv-hevc，3D视频生效，可选值：
        /// <li>side_by_side：原视频内容左右排列布局</li>
        /// <li>top_bottom：原视频内容上下排列布局</li>
        /// 计费将按照切分后的分辨率尺寸上报用量及计费；
        /// 默认值:side_by_side
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Stereo3dType")]
        public string Stereo3dType{ get; set; }

        /// <summary>
        /// Profile，适用于不同场景。 
        /// baseline: 只支持I/P帧，并只支持无交错的场景，适用于视频通话、手机视频等场景。 
        /// main: 主流Profile，提供I帧、P帧、B帧，并支持无交错模式和交错模式。主要用在主流的音视频消费产品如视频播放器、流媒体传输设备上。 
        /// high: 最高编码等级，在Main Profile上添加了8X8的预测，并支持自定义量化。广泛应用在蓝光存储、高清电视等场景。
        /// default：随原视频自动填充
        /// 
        /// 仅编码标准选择h264时出现该配置，默认为：default
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoProfile")]
        public string VideoProfile{ get; set; }

        /// <summary>
        /// 编码器级别，默认为自动（""）
        /// 若编码标准选择H264: 支持以下选项：""，1 , 1.1 , 1.2 , 1.3 , 2 , 2.1 , 2.2 , 3 , 3.1 , 3.2 , 4 , 4.1 , 4.2 , 5 , 5.1 
        /// 若编码标准选择H265: 支持以下选项：""，1 , 2 , 2.1 , 3 , 3.1 , 4 , 4.1 , 5 , 5.1 , 5.2 , 6 , 6.1 , 6.2 , 8.5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoLevel")]
        public string VideoLevel{ get; set; }

        /// <summary>
        /// 最大连续B帧数，默认选自动，支持 0 - 16和-1
        /// 注意：
        /// -1表示修改为自动值	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Bframes")]
        public long? Bframes{ get; set; }

        /// <summary>
        /// 码率控制模式：可选值： 
        /// VBR（Variable Bit Rate）：动态比特率，根据视频画面的复杂度动态调整输出的码率，使得画面质量更高，适用于存储场景和对画面质量要求较高的应用。 
        /// ABR（Average Bit Rate）：平均比特率，尽量保持输出视频的平均码率稳定，但允许短期内的码率波动，适用于需要在保持一定画质的情况下尽量减少整体码率的场景。 
        /// CBR（Constant Bit Rate）：恒定比特率，指视频编码时输出的码率保持恒定不变，不考虑画面复杂度的变化，适用于对网络带宽要求较为严格的场景，如直播等。 
        /// VCRF（Constant Rate Factor）：恒定质量因子，通过设定一个质量因子来控制视频质量，实现视频的恒定质量编码，码率会根据内容的复杂度自动调整，适用于希望保持一定画质的场景。 
        /// 默认选择 VBR
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 显示高宽比，可选值：[1:1，2:1，default]
        /// 默认值：default
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sar")]
        public string Sar{ get; set; }

        /// <summary>
        /// 自适应I帧决策，开启后，媒体处理将自动识别视频中不同场景之间的过渡点（通常是视觉上显著不同的帧，比如从一个镜头切换到另一个镜头），在这些点自适应插入关键帧（I帧），从而提高视频的随机访问性和编码效率。可选值： 
        /// 0：关闭自适应I帧决策 
        /// 1：使用自适应I帧决策 
        /// 默认值：0	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NoScenecut")]
        public long? NoScenecut{ get; set; }

        /// <summary>
        /// 比特位：支持8/10，默认为8	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BitDepth")]
        public long? BitDepth{ get; set; }

        /// <summary>
        /// 保持原始时间戳：可选值： 
        /// 0：表示关闭 
        /// 1：表示打开 
        /// 默认是关闭	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RawPts")]
        public long? RawPts{ get; set; }

        /// <summary>
        /// 按比例压缩码率，开启后，将根据比例来调整输出视频的码率。填写压缩率后，系统会根据视频源码率自动计算目标输出码率。压缩率范围0-100，可选值：[0-100]和-1 
        /// 注意：-1表示修改为自动	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Compress")]
        public long? Compress{ get; set; }

        /// <summary>
        /// 启动时分片时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SegmentSpecificInfo")]
        public SegmentSpecificInfo SegmentSpecificInfo{ get; set; }

        /// <summary>
        /// 模板是否开启场景化 
        /// 0：不开启 
        /// 1：开启 
        /// 默认值：0	
        /// 注意：只有此字段值为1时，SceneType和CompressType字段的值才会生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScenarioBased")]
        public long? ScenarioBased{ get; set; }

        /// <summary>
        /// 视频场景化，可选值： 
        /// normal：通用转码场景：通用转码压缩场景 pgc：PGC高清影视：压缩时会注重影视剧的观看体验，根据影视剧特性进行ROI编码，同时保留高质量的视频内容和音频。 
        /// materials_video：高清素材：素材资源类场景，对画质要求极高，较多透明画面内容，在压缩的同时接近视觉无损。 
        /// ugc：UGC内容：适用于广泛的UGC/短视频场景，针对短视频的特性优化编码码率， 画质提升，提升业务QOS/QOE指标。 
        /// e-commerce_video：秀场/电商类：压缩时会强调细节清晰度和ROI区域提升，尤其注重保持人脸区域的画质。 
        /// educational_video：教育类：压缩时会强调文字和图像的清晰度和可读性，以便学生更好地理解内容，确保讲解内容清晰传达。
        /// 默认值：normal
        /// 注意：要使用此值ScenarioBased的值必须为1，否则此值不生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// 转码策略，可选值： 
        /// ultra_compress：极致压缩：相比标准压缩，该策略能在保证一定画质的基础上最大限度压缩码率，极大节约带宽和存储成本。 
        /// standard_compress：综合最优：平衡压缩率与画质，在保证主观画质没有明显降低的情况下尽可能压缩文件。该策略仅收取音视频极速高清转码费用。 
        /// high_compress：码率优先：优先保证降低文件体积大小，可能有一定画质损失。该策略仅收取音视频极速高清转码费用。 
        /// low_compress：画质优先：优先保证画质，压缩出来的文件体积可能相对较大。该策略仅收取音视频极速高清转码费用。 
        /// 默认值：standard_compress 
        /// 注：若需要在电视上观看视频，不建议使用ultra_compress策略。ultra_compress策略计费标准为极速高清转码 + 音视频增强-去毛刺。
        /// 注意：要使用此值ScenarioBased的值必须为1，否则此值不生效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "GopUnit", this.GopUnit);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Vcrf", this.Vcrf);
            this.SetParamSimple(map, prefix + "ContentAdaptStream", this.ContentAdaptStream);
            this.SetParamSimple(map, prefix + "HlsTime", this.HlsTime);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "FpsDenominator", this.FpsDenominator);
            this.SetParamSimple(map, prefix + "Stereo3dType", this.Stereo3dType);
            this.SetParamSimple(map, prefix + "VideoProfile", this.VideoProfile);
            this.SetParamSimple(map, prefix + "VideoLevel", this.VideoLevel);
            this.SetParamSimple(map, prefix + "Bframes", this.Bframes);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Sar", this.Sar);
            this.SetParamSimple(map, prefix + "NoScenecut", this.NoScenecut);
            this.SetParamSimple(map, prefix + "BitDepth", this.BitDepth);
            this.SetParamSimple(map, prefix + "RawPts", this.RawPts);
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
            this.SetParamObj(map, prefix + "SegmentSpecificInfo.", this.SegmentSpecificInfo);
            this.SetParamSimple(map, prefix + "ScenarioBased", this.ScenarioBased);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

